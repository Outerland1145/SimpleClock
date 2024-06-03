using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboboxInitialzation();
            TimerClock.Start();
        }
        private void comboboxInitialzation()
        {
            // 設定小時下拉選單的選單內容，建立小時的清單，數字範圍為00-23
            for (int i = 0; i <= 23; i++)
                cmbHour.Items.Add(string.Format("{0:00}", i));
            cmbHour.SelectedIndex = 0;

            // 設定分鐘下拉選單的選單內容，建立分鐘的清單，數字範圍為00-59
            for (int i = 0; i <= 59; i++)
                cmbMin.Items.Add(string.Format("{0:00}", i));
            cmbMin.SelectedIndex = 0;
        }

        private void TimerClock_Tick_1(object sender, EventArgs e)
        {
            TxtTimer.Text = DateTime.Now.ToString("HH:mm:ss");    // 顯示時間
            TxtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");  // 顯示日期
            TxtWeekday.Text = DateTime.Now.ToString("dddd");     // 顯示星期幾
        }

        private void TimerAlert_Tick(object sender, EventArgs e)
        {

        }
    }
}
