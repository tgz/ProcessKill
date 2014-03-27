using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;

using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace CleanWordProcess
{
    public partial class form1 : Form
    {
        ////使用timer类定时
        //System.Timers.Timer clock;

        public form1()
        {
            InitializeComponent();
            ////开线程操作实例
            ////关闭不安全线程提示
            //RichTextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //锁定编辑框
            processName.ReadOnly = true;
            processName.Enabled = false;
            WordCount.ReadOnly = true;
            WordCount.Enabled = false;
            ClockInterval.ReadOnly = true;
            ClockInterval.Enabled = false;
            maxTime.ReadOnly = true;
            maxTime.Enabled = false;
            //锁定按钮
            button1.Enabled = false;
            killNow.Enabled = false;
            //创建定时器
            int interval = Convert.ToInt32(ClockInterval.Text);
            ////timer实例化,
            //clock = new System.Timers.Timer();
            //clock.Interval = interval * 1000;
            //clock.Elapsed += new ElapsedEventHandler(kill);
            //clock.AutoReset = true;
            //clock.Enabled = true;
            //clock.Start();
            //form上的timer控件实例
            timer1.Interval = interval * 1000;
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.killNow_Click);
            runState.Text = "正在监控";
        }
        /// <summary>
        /// 定时器杀死进程
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void kill(object source, ElapsedEventArgs e)
        {
            ////开启线程杀进程
            //Thread t = new Thread(killOnce);
            //t.Start();


        }
        /// <summary>
        /// 执行一次杀进程操作
        /// </summary>
        private void killOnce()
        {

            int allowCount = Convert.ToInt32(WordCount.Text.Trim());
            Process[] p = Process.GetProcessesByName(processName.Text);
            int maxtime = Convert.ToInt32(maxTime.Text);

            int count = p.Length;
            //检查超时进程
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    string starttime = p[i].StartTime.ToShortTimeString();
                    int runTime = getRunTime(p[i].StartTime);
                    if (runTime > maxtime)
                    {

                        log.AppendText(DateTime.Now.ToString() + "杀死进程 " + p[i].ProcessName + " 进程开始时间：" + starttime + " 共运行 " + runTime.ToString() + " 分钟");
                        p[i].Kill();
                        log.AppendText("!");
                        log.AppendText(Environment.NewLine);
                    }
                }
            }
            //进程数量爆表时直接全杀
            if (count > allowCount)
            {
                log.AppendText("进程数达到" + count + "个！杀杀杀！");
                for (int i = 0; i < count; i++)
                {
                    string starttime = p[i].StartTime.ToShortTimeString();
                    int runTime = getRunTime(p[i].StartTime);

                    log.AppendText(DateTime.Now.ToString() + "杀死进程 " + p[i].ProcessName + " 进程开始时间：" + starttime + " 共运行 " + runTime.ToString() + " 分钟");
                   
                    p[i].Kill();
                   
                    log.AppendText("!");
                    log.AppendText(Environment.NewLine);
                }                
                log.AppendText("杀完收工");
                log.AppendText(Environment.NewLine);

            }
            setProcessCount();


        }
        private int getRunTime(DateTime start)
        {
            DateTime now = DateTime.Now;
            TimeSpan span = now - start;
            return span.Minutes;
        }
        //执行一次按钮的操作
        private void killNow_Click(object sender, EventArgs e)
        {
            killOnce();
            setProcessCount();
        }
        private void setProcessCount()
        {
            Process[] p = Process.GetProcessesByName(processName.Text);
            processNow.Text = p.Length.ToString();

        }

        private void processName_TextChanged(object sender, EventArgs e)
        {
            setProcessCount();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
