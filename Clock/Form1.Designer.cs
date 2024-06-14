
namespace Clock
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clock = new System.Windows.Forms.TabPage();
            this.TxtWeekday = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtTimer = new System.Windows.Forms.TextBox();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.Stopwatch = new System.Windows.Forms.TabPage();
            this.countdown_timer = new System.Windows.Forms.TabPage();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.TimerAlert = new System.Windows.Forms.Timer(this.components);
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Clock.SuspendLayout();
            this.Stopwatch.SuspendLayout();
            this.countdown_timer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clock);
            this.tabControl1.Controls.Add(this.Stopwatch);
            this.tabControl1.Controls.Add(this.countdown_timer);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Clock
            // 
            this.Clock.Controls.Add(this.TxtWeekday);
            this.Clock.Controls.Add(this.TxtDate);
            this.Clock.Controls.Add(this.TxtTimer);
            this.Clock.Controls.Add(this.cmbMin);
            this.Clock.Controls.Add(this.cmbHour);
            this.Clock.Controls.Add(this.label1);
            this.Clock.Controls.Add(this.btnCancelAlert);
            this.Clock.Controls.Add(this.btnSetAlert);
            this.Clock.Location = new System.Drawing.Point(4, 22);
            this.Clock.Name = "Clock";
            this.Clock.Padding = new System.Windows.Forms.Padding(3);
            this.Clock.Size = new System.Drawing.Size(768, 400);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "時鐘";
            this.Clock.UseVisualStyleBackColor = true;
            // 
            // TxtWeekday
            // 
            this.TxtWeekday.Enabled = false;
            this.TxtWeekday.Font = new System.Drawing.Font("新細明體", 50F);
            this.TxtWeekday.Location = new System.Drawing.Point(400, 157);
            this.TxtWeekday.Name = "TxtWeekday";
            this.TxtWeekday.Size = new System.Drawing.Size(335, 87);
            this.TxtWeekday.TabIndex = 10;
            this.TxtWeekday.Text = "星期日";
            this.TxtWeekday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDate
            // 
            this.TxtDate.Enabled = false;
            this.TxtDate.Font = new System.Drawing.Font("新細明體", 50F);
            this.TxtDate.Location = new System.Drawing.Point(40, 157);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(335, 87);
            this.TxtDate.TabIndex = 9;
            this.TxtDate.Text = "2021-19-31";
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTimer
            // 
            this.TxtTimer.Enabled = false;
            this.TxtTimer.Font = new System.Drawing.Font("新細明體", 50F);
            this.TxtTimer.Location = new System.Drawing.Point(40, 33);
            this.TxtTimer.Name = "TxtTimer";
            this.TxtTimer.Size = new System.Drawing.Size(695, 87);
            this.TxtTimer.TabIndex = 8;
            this.TxtTimer.Text = "00:00:00";
            this.TxtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbMin
            // 
            this.cmbMin.Font = new System.Drawing.Font("新細明體", 36F);
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(178, 283);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(93, 56);
            this.cmbMin.TabIndex = 7;
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("新細明體", 36F);
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(40, 283);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(93, 56);
            this.cmbHour.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(139, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.Font = new System.Drawing.Font("新細明體", 30F);
            this.btnCancelAlert.Location = new System.Drawing.Point(550, 286);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(185, 47);
            this.btnCancelAlert.TabIndex = 4;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = true;
            this.btnCancelAlert.Click += new System.EventHandler(this.btnCancelAlert_Click);
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Font = new System.Drawing.Font("新細明體", 30F);
            this.btnSetAlert.Location = new System.Drawing.Point(324, 286);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(185, 47);
            this.btnSetAlert.TabIndex = 3;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            this.btnSetAlert.Click += new System.EventHandler(this.btnSetAlert_Click);
            // 
            // Stopwatch
            // 
            this.Stopwatch.Controls.Add(this.btnstop);
            this.Stopwatch.Controls.Add(this.btnlog);
            this.Stopwatch.Controls.Add(this.btnreset);
            this.Stopwatch.Controls.Add(this.btnpause);
            this.Stopwatch.Controls.Add(this.btnstart);
            this.Stopwatch.Controls.Add(this.listStopWatchLog);
            this.Stopwatch.Controls.Add(this.txtStopWatch);
            this.Stopwatch.Location = new System.Drawing.Point(4, 22);
            this.Stopwatch.Name = "Stopwatch";
            this.Stopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.Stopwatch.Size = new System.Drawing.Size(768, 400);
            this.Stopwatch.TabIndex = 1;
            this.Stopwatch.Text = "碼表";
            this.Stopwatch.UseVisualStyleBackColor = true;
            // 
            // countdown_timer
            // 
            this.countdown_timer.Controls.Add(this.button3);
            this.countdown_timer.Controls.Add(this.button2);
            this.countdown_timer.Controls.Add(this.button1);
            this.countdown_timer.Controls.Add(this.comboBox1);
            this.countdown_timer.Controls.Add(this.comboBox2);
            this.countdown_timer.Controls.Add(this.comboBox3);
            this.countdown_timer.Controls.Add(this.textBox1);
            this.countdown_timer.Location = new System.Drawing.Point(4, 22);
            this.countdown_timer.Name = "countdown_timer";
            this.countdown_timer.Size = new System.Drawing.Size(768, 400);
            this.countdown_timer.TabIndex = 2;
            this.countdown_timer.Text = "倒數";
            this.countdown_timer.UseVisualStyleBackColor = true;
            // 
            // TimerClock
            // 
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick_1);
            // 
            // TimerAlert
            // 
            this.TimerAlert.Tick += new System.EventHandler(this.TimerAlert_Tick);
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Enabled = false;
            this.txtStopWatch.Font = new System.Drawing.Font("新細明體", 56F);
            this.txtStopWatch.Location = new System.Drawing.Point(6, 3);
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.Size = new System.Drawing.Size(756, 97);
            this.txtStopWatch.TabIndex = 0;
            this.txtStopWatch.Text = "00:00:00:000";
            this.txtStopWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 12;
            this.listStopWatchLog.Location = new System.Drawing.Point(6, 118);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(239, 268);
            this.listStopWatchLog.TabIndex = 1;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Green;
            this.btnstart.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnstart.Location = new System.Drawing.Point(336, 142);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(168, 63);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "開始";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.Color.Yellow;
            this.btnpause.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnpause.Location = new System.Drawing.Point(510, 142);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(168, 63);
            this.btnpause.TabIndex = 3;
            this.btnpause.Text = "暫停";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Teal;
            this.btnreset.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnreset.Location = new System.Drawing.Point(336, 211);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(168, 63);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "歸零";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.Teal;
            this.btnlog.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnlog.Location = new System.Drawing.Point(510, 211);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(168, 63);
            this.btnlog.TabIndex = 5;
            this.btnlog.Text = "記錄";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Red;
            this.btnstop.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnstop.Location = new System.Drawing.Point(336, 280);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(342, 63);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "歸零並清除所有記錄";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 56F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(762, 97);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "00:00:00:000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 36F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(558, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 56);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("新細明體", 36F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 56);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("新細明體", 36F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(264, 106);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(236, 56);
            this.comboBox3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("新細明體", 36F);
            this.button1.Location = new System.Drawing.Point(264, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 36F);
            this.button2.Location = new System.Drawing.Point(264, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "暫停";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("新細明體", 36F);
            this.button3.Location = new System.Drawing.Point(264, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 57);
            this.button3.TabIndex = 13;
            this.button3.Text = "停止";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Clock.ResumeLayout(false);
            this.Clock.PerformLayout();
            this.Stopwatch.ResumeLayout(false);
            this.Stopwatch.PerformLayout();
            this.countdown_timer.ResumeLayout(false);
            this.countdown_timer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clock;
        private System.Windows.Forms.TabPage Stopwatch;
        private System.Windows.Forms.TabPage countdown_timer;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.TextBox TxtWeekday;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtTimer;
        private System.Windows.Forms.Timer TimerClock;
        private System.Windows.Forms.Timer TimerAlert;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

