using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Diagnostics;

namespace Clock
{
    public partial class Form1 : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private string mp3FilePath;
        string strSelectTime;
        List<string> StopWatchLog = new List<string>(); 
        Stopwatch sw = new Stopwatch();
        bool isCountDownReset = true;
        TimeSpan ts;
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
            {
                cmbHour.Items.Add(string.Format("{0:00}", i));
                cmbCountHour.Items.Add(string.Format("{0:00}", i));
            }
                

            // 設定分鐘下拉選單的選單內容，建立分鐘的清單，數字範圍為00-59
            for (int i = 0; i <= 59; i++)
            {
                cmbMin.Items.Add(string.Format("{0:00}", i));
                cmbCountMin.Items.Add(string.Format("{0:00}", i));
                cmbCountSec.Items.Add(string.Format("{0:00}", i));
            }
                

            //倒數計時器下拉選單
            cmbHour.SelectedIndex = 0;
            cmbMin.SelectedIndex = 0;
            cmbCountHour.SelectedIndex = 0;
            cmbCountMin.SelectedIndex = 0;
            cmbCountSec.SelectedIndex = 0;
        }

        private void TimerClock_Tick_1(object sender, EventArgs e)
        {
            TxtTimer.Text = DateTime.Now.ToString("HH:mm:ss");    // 顯示時間
            TxtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");  // 顯示日期
            TxtWeekday.Text = DateTime.Now.ToString("dddd");     // 顯示星期幾
        }

        private void TimerAlert_Tick(object sender, EventArgs e)
        {
            // 判斷現在時間是不是已經是鬧鐘設定時間？如果時間到了，就要播放鬧鐘聲音
            if (strSelectTime == DateTime.Now.ToString("HH:mm"))
            {
                playAlert(TimerAlert);
            }
        }
        private void stopWaveOut()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void btnSetAlert_Click(object sender, EventArgs e)
        {
            //LoadAlert();
            LoadAlert(1);
            btnSetAlert.Enabled = false;
            btnCancelAlert.Enabled = true;
            strSelectTime = cmbHour.SelectedItem.ToString() + ":" + cmbMin.SelectedItem.ToString(); // 擷取小時和分鐘的下拉選單文字，用來設定鬧鐘時間
        }

        private void btnCancelAlert_Click(object sender, EventArgs e)
        {
            stopWaveOut();     // 停止之前的播放
            TimerAlert.Stop(); // 停止鬧鐘計時器
            btnSetAlert.Enabled = true;
            btnCancelAlert.Enabled = false;
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            txtStopWatch.Text = sw.Elapsed.ToString("hh':'mm':'ss':'fff");    // 顯示碼表時間
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            sw.Start();             // 啟動碼表
            timerStopWatch.Start(); // 開始讓碼表文字顯示
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            sw.Stop();                  // 停止碼表，但不歸零
            timerStopWatch.Stop();      // 停止讓碼表文字顯示  
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                logRecord();
                sw.Restart(); // 歸零碼表，碼表仍繼續進行  
            }
            else
            {
                sw.Reset(); // 如果碼表沒在跑，停止並歸零碼表
                txtStopWatch.Text = "00:00:00:000";   // 讓碼表文字「歸零」
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            logRecord();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            sw.Reset();                           // 停止並歸零碼表
            timerStopWatch.Stop();                // 停止讓碼表文字顯示     
            txtStopWatch.Text = "00:00:00:000";   // 讓碼表文字「歸零」
            listStopWatchLog.Items.Clear();       // 清空 ListBox 中的元素
            StopWatchLog.Clear();                 // 清除暫存碼表紀錄清單
        }
        private void logRecord()
        {
            listStopWatchLog.Items.Clear(); // 清空 ListBox 中的元素
            StopWatchLog.Add(txtStopWatch.Text); // 將碼表時間增加到暫存碼表紀錄清單裡

            // 依照碼表紀錄清單「依照最新時間順序」顯示
            int i = StopWatchLog.Count;
            while (i > 0)
            {
                listStopWatchLog.Items.Add(String.Format("第 {0} 筆紀錄：{1}", i.ToString(), StopWatchLog[i - 1] + "\n"));
                i--;
            }
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            txtCountDown.Text = ts.ToString("hh':'mm':'ss");    // 顯示時間
            ts = ts.Subtract(TimeSpan.FromSeconds(1));          // 每一秒鐘將顯示時間減掉一秒
            
            if (txtCountDown.Text == "00:00:00")
            {
                playAlert(timerCountDown);
            }
        }

        private void btnCountStart_Click(object sender, EventArgs e)
        {
            // 進行判斷，判斷是不是有按過停止計時器按鍵
            if (isCountDownReset == true)
            {
                int Hour = int.Parse(cmbCountHour.SelectedItem.ToString());
                int Min = int.Parse(cmbCountMin.SelectedItem.ToString());
                int Sec = int.Parse(cmbCountSec.SelectedItem.ToString());
                ts = new TimeSpan(Hour, Min, Sec); // 設定倒數時間
            }
            isCountDownReset = false;
            LoadAlert(2);
        }

        private void btnCountPause_Click(object sender, EventArgs e)
        {
            timerCountDown.Stop();
        }

        private void btnCountStop_Click(object sender, EventArgs e)
        {
            stopWaveOut(); // 關閉鬧鐘聲音
            isCountDownReset = true;
            timerCountDown.Stop();
            txtCountDown.Text = "00:00:00";
            cmbCountHour.SelectedIndex = 0;
            cmbCountMin.SelectedIndex = 0;
            cmbCountSec.SelectedIndex = 0;
        }
        //讀取Mp3文件
        private void LoadAlert(int timer_mode)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV 檔案 (*.wav)|*.wav|MP3 檔案 (*.mp3)|*.mp3|所有檔案 (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mp3FilePath = openFileDialog.FileName;
                    if(timer_mode == 1)
                    {
                        TimerAlert.Start();
                    }
                    else if(timer_mode == 2)
                    {
                        timerCountDown.Start();
                    }
                }
            }
        }
        //播放Mp3文件
        private void playAlert(System.Windows.Forms.Timer timer)
        {
            try
            {
                stopWaveOut();
                waveOut = new WaveOutEvent();
                audioFileReader = new AudioFileReader(mp3FilePath);
                waveOut.Init(audioFileReader);
                waveOut.Play();
                MessageBox.Show("時間到! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法播放聲音檔，錯誤資訊: " + ex.Message);
            }
            finally
            {
                timer.Stop();
            }
        }
    }

}
