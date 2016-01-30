using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Astrid.Common.Timing;
using Astrid.Video;

using System.IO;

namespace Astrid {
    /*
    * 本demo采用的是 语音视频采集组件MCapture 和 语音视频录制组件MFile 的免费版本。若想获取MCapture、MFile的其它版本，请联系 www.oraycn.com ,客服qq：168757008。
    * 
    */
    public partial class MainForm : Form {

        private VideoPlayer player;

        private TimingController controller = new TimingController();
        public MainForm() {
            InitializeComponent();

            controller.Enabled = true;
            controller.TextDisplay = this.lblTime;
            controller.LogDisplay = this.txtLogs;
            controller.ProgressDisplay = this.prgRecording;

            SimpleTime now = new SimpleTime(System.DateTime.Now);
            int t = now.TotalSecond;
            controller.AddTimePeriod(new SimpleTimePeriod(new SimpleTime(t + 5), new SimpleTime(t + 20), "1"));
            controller.AddTimePeriod(new SimpleTimePeriod(new SimpleTime(t + 25), new SimpleTime(t + 30), "2"));
            controller.AddTimePeriod(new SimpleTimePeriod(new SimpleTime(t + 31), new SimpleTime(t + 60), "3"));


            UpdateAddedPeriods();

        }

        private void UpdateAddedPeriods() {
            List<SimpleTimePeriod> periods = controller.Periods;
            lstAddedPeriods.Items.Clear();
            periods.ForEach(delegate (SimpleTimePeriod p) {
                lstAddedPeriods.Items.Add(p.ToString());
            });
        }

        private void cmdAddPeriod_Click(object sender, EventArgs e) {
            SimpleTime start = new SimpleTime(timePicStart.Value);
            SimpleTime end = new SimpleTime(timePicEnd.Value);
            SimpleTimePeriod period = new SimpleTimePeriod(start, end);
            bool success = controller.AddTimePeriod(period);

            if (success) {
                UpdateAddedPeriods();
            }
            else {
                MessageBox.Show("未能添加时段，请检查该时段是否与已添加的时段有重叠。");
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void cmdSwitchDisplayVideo_Click(object sender, EventArgs e) {
            //if (player.IsDisplaying) {
            //    player.Hide();
            //    player.Dispose();
            //    this.cmdSwitchDisplayVideo.Text = "同时打开录像播放";
            //    this.controller.VideoDisplay = null;
            //}
            //else {
            //    player = new VideoPlayer();
            //    this.cmdSwitchDisplayVideo.Text = "关闭录像播放";
            //    this.controller.VideoDisplay = this.player.ImageDisplay;
            //    player.Show();
            //}
        }


    }
}
