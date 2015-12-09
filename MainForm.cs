using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Astrid.Timing;
using Astrid.Video;

using System.IO;

namespace Astrid {
    /*
    * 本demo采用的是 语音视频采集组件MCapture 和 语音视频录制组件MFile 的免费版本。若想获取MCapture、MFile的其它版本，请联系 www.oraycn.com ,客服qq：168757008。
    * 
    */
    public partial class MainForm : Form
    {



        private TimingController controller = new TimingController();
        public MainForm()
        {
            InitializeComponent();

            controller.Enabled = true;
            controller.Display = this.pictureBox1;

            SimpleTime now = new SimpleTime(System.DateTime.Now);
            int t = now.TotalSecond;
            controller.AddTimePeriod(new SimpleTimePeriod(new SimpleTime(t+5), new SimpleTime(t+65), "1"));
            controller.AddTimePeriod(new SimpleTimePeriod(new SimpleTime(t+70), new SimpleTime(t+200), "2"));
            controller.AddTimePeriod(new SimpleTimePeriod(new SimpleTime(t+201), new SimpleTime(t+300), "3"));

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
