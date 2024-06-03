
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clock = new System.Windows.Forms.TabPage();
            this.Stopwatch = new System.Windows.Forms.TabPage();
            this.countdown_timer = new System.Windows.Forms.TabPage();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtWeekDay = new System.Windows.Forms.Label();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Clock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clock);
            this.tabControl1.Controls.Add(this.Stopwatch);
            this.tabControl1.Controls.Add(this.countdown_timer);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Clock
            // 
            this.Clock.Controls.Add(this.cmbMin);
            this.Clock.Controls.Add(this.cmbHour);
            this.Clock.Controls.Add(this.label1);
            this.Clock.Controls.Add(this.btnCancelAlert);
            this.Clock.Controls.Add(this.btnSetAlert);
            this.Clock.Controls.Add(this.txtWeekDay);
            this.Clock.Controls.Add(this.txtDate);
            this.Clock.Controls.Add(this.txtTime);
            this.Clock.Location = new System.Drawing.Point(4, 22);
            this.Clock.Name = "Clock";
            this.Clock.Padding = new System.Windows.Forms.Padding(3);
            this.Clock.Size = new System.Drawing.Size(768, 400);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "時鐘";
            this.Clock.UseVisualStyleBackColor = true;
            // 
            // Stopwatch
            // 
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
            this.countdown_timer.Location = new System.Drawing.Point(4, 22);
            this.countdown_timer.Name = "countdown_timer";
            this.countdown_timer.Size = new System.Drawing.Size(768, 400);
            this.countdown_timer.TabIndex = 2;
            this.countdown_timer.Text = "倒數";
            this.countdown_timer.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("新細明體", 48F);
            this.txtTime.Location = new System.Drawing.Point(259, 60);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(242, 64);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "13:49:00";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("新細明體", 40F);
            this.txtDate.Location = new System.Drawing.Point(94, 184);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(207, 54);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "2024-6-3";
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.AutoSize = true;
            this.txtWeekDay.Font = new System.Drawing.Font("新細明體", 40F);
            this.txtWeekDay.Location = new System.Drawing.Point(460, 184);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(185, 54);
            this.txtWeekDay.TabIndex = 2;
            this.txtWeekDay.Text = "星期五";
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Font = new System.Drawing.Font("新細明體", 30F);
            this.btnSetAlert.Location = new System.Drawing.Point(359, 286);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(185, 47);
            this.btnSetAlert.TabIndex = 3;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(192, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("新細明體", 36F);
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(93, 283);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(93, 56);
            this.cmbHour.TabIndex = 6;
            // 
            // cmbMin
            // 
            this.cmbMin.Font = new System.Drawing.Font("新細明體", 36F);
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(231, 283);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(93, 56);
            this.cmbMin.TabIndex = 7;
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
        private System.Windows.Forms.Label txtWeekDay;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtTime;
    }
}

