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
            //timerClcok.Start();
        }
        private void timerClcok_Tick(object sender, EventArgs e)
        {
            TxtTimer.Text = DateTime.Now.ToString("HH:mm:ss");    // 顯示時間
            TxtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");  // 顯示日期
            TxtWeekday.Text = DateTime.Now.ToString("dddd");     // 顯示星期幾
        }
    }
}
