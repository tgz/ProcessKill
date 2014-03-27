namespace CleanWordProcess
{
    partial class form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.button1 = new System.Windows.Forms.Button();
            this.killNow = new System.Windows.Forms.Button();
            this.WordCount = new System.Windows.Forms.TextBox();
            this.processNow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClockInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.runState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.MaximumSize = new System.Drawing.Size(75, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "启动监控";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // killNow
            // 
            this.killNow.Location = new System.Drawing.Point(93, 12);
            this.killNow.Name = "killNow";
            this.killNow.Size = new System.Drawing.Size(70, 23);
            this.killNow.TabIndex = 1;
            this.killNow.Text = "执行一次";
            this.killNow.UseVisualStyleBackColor = true;
            this.killNow.Click += new System.EventHandler(this.killNow_Click);
            // 
            // WordCount
            // 
            this.WordCount.Location = new System.Drawing.Point(47, 68);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(42, 21);
            this.WordCount.TabIndex = 2;
            this.WordCount.Text = "10";
            // 
            // processNow
            // 
            this.processNow.AutoSize = true;
            this.processNow.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processNow.Location = new System.Drawing.Point(374, 11);
            this.processNow.Name = "processNow";
            this.processNow.Size = new System.Drawing.Size(14, 14);
            this.processNow.TabIndex = 3;
            this.processNow.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(297, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前进程数";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(3, 96);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(455, 160);
            this.log.TabIndex = 6;
            this.log.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "超过";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "扫描间隔";
            // 
            // ClockInterval
            // 
            this.ClockInterval.Location = new System.Drawing.Point(71, 43);
            this.ClockInterval.Name = "ClockInterval";
            this.ClockInterval.Size = new System.Drawing.Size(42, 21);
            this.ClockInterval.TabIndex = 9;
            this.ClockInterval.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "监控的进程名：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // processName
            // 
            this.processName.Location = new System.Drawing.Point(299, 43);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(128, 21);
            this.processName.TabIndex = 11;
            this.processName.Text = "WINWORD";
            this.processName.TextChanged += new System.EventHandler(this.processName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "杀死超过";
            // 
            // maxTime
            // 
            this.maxTime.Location = new System.Drawing.Point(267, 67);
            this.maxTime.Name = "maxTime";
            this.maxTime.Size = new System.Drawing.Size(40, 21);
            this.maxTime.TabIndex = 13;
            this.maxTime.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "分钟的进程";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "个进程直接全杀";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(395, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "By.邱士川";
            // 
            // runState
            // 
            this.runState.AutoSize = true;
            this.runState.Location = new System.Drawing.Point(214, 12);
            this.runState.Name = "runState";
            this.runState.Size = new System.Drawing.Size(53, 12);
            this.runState.TabIndex = 18;
            this.runState.Text = "监控状态";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 259);
            this.Controls.Add(this.runState);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.processName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClockInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processNow);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.killNow);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "进程专杀";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button killNow;
        private System.Windows.Forms.TextBox WordCount;
        private System.Windows.Forms.Label processNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClockInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox processName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label runState;
    }
}

