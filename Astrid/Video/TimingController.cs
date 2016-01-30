using System;
using System.Collections.Generic;
using System.Text;
using Astrid.Common.Timing;
using Astrid.Video;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;
namespace Astrid.Video {
    class TimingController {

        /// <summary>
        /// 记录仪。
        /// </summary>
        private Mp4FileAccessRecorder recorder = new Mp4FileAccessRecorder();
        /// <summary>
        /// 给定的录制时间段，必须保证时段没有重叠。
        /// </summary>
        private List<SimpleTimePeriod> periods = new List<SimpleTimePeriod>();
        /// <summary>
        /// 用于控制录制时间的定时器。
        /// </summary>
        private Timer timer = new Timer();
        /// <summary>
        /// 定时录制控制器使能。
        /// </summary>
        private bool enabled = false;
        /// <summary>
        /// 用于显示正在录制的视频。
        /// </summary>
        private PictureBox pic = null;
        /// <summary>
        /// 用于显示文本状态信息的控件。
        /// </summary>
        private Control info = null;
        /// <summary>
        /// 当前正在录制的时段。
        /// </summary>
        /// 
        private Control logs = null;
        private ProgressBar prg = null;
        private SimpleTimePeriod currentPeriod = null;
        private string currentFileName = null;



        public TimingController() {
            timer.Interval = 1000;
            timer.Tick += OnTimeChanged;
            timer.Enabled = true;

            recorder.OnImageCaptured = new ImageDelegate(delegate (Bitmap bitmap) {
                if (pic != null) {
                    pic.BackgroundImage = bitmap;
                }
            });
        }

        public bool Enabled {
            get {
                return enabled;
            }
            set {
                enabled = value;
            }
        }
        public PictureBox VideoDisplay {
            set {
                pic = value;
            }
        }
        public Control TextDisplay {
            set {
                info = value;
            }
        }
        public Control LogDisplay {
            set {
                logs = value;
            }
        }

        public ProgressBar ProgressDisplay {
            set {
                prg = value;
                prg.Maximum = 100;
                prg.Minimum = 0;
            }
        }

        public List<SimpleTimePeriod> Periods {
            get {
                return periods;
            }
        }
        public bool AddTimePeriod(SimpleTimePeriod period) {


            bool f = true;


            if (period.Period.TotalSecond < 3) {
                f = false;
            }

            periods.ForEach(delegate (SimpleTimePeriod p) {
                if (p.GetOverlap(period).TotalSecond != 0) {
                    f = false;
                }
            });

            if (f) {
                periods.Add(period);
            }
            return f;
        }
        


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void OnTimeChanged( object s, EventArgs e) {
            if (enabled) {
                SimpleTime now = new SimpleTime(System.DateTime.Now);
                periods.ForEach(delegate (SimpleTimePeriod p) {
                    if (now.Equals(p.Start)) {
                        Start(p.ToString().Replace(":","：").Replace("-","到"), p);

                    }
                    else if (now.Equals(p.End)) {
                        Stop();

                    }
                    else {

                    }
                });
                
            }
            UpdateTextInfo();
           
        }

        private void Start(string fileName, SimpleTimePeriod p) {
            recorder.Initialize(fileName);
            recorder.Start();
            if (logs != null) {
                logs.Text += "【开始录制】 " + p.ToString() + "\r\n";
            }

            currentPeriod = p;
            currentFileName = fileName;
        }

        private void Stop() {
            recorder.Stop();
            if (pic != null) {
                pic.BackgroundImage = null;
            }
            if (logs != null) {
                logs.Text += "【结束并保存】 " + recorder.CurrentFilePath  + "\r\n";
            }
            currentPeriod = null;
        }

        private void UpdateTextInfo() {

            if (info != null) {
                if (Enabled) {
                    if (recorder.IsRecording) {
                        float percentage = (float)recorder.Timing.TotalSecond / currentPeriod.Period.TotalSecond;
                        info.Text = "正在录制\n " + currentPeriod.ToString() + "\n共" + currentPeriod.Period.ToString() + "\n已完成 " + string.Format("{0:0%}", percentage) + "\n";
                        prg.Value = (int)Math.Round(percentage*100);
                    }
                    else {
                        prg.Value = prg.Maximum;
                        info.Text = "已停止录制。";
                    }
                }
                else {
                    info.Text = "未开启定时录制功能。";
                }
            }
        }

        
    }
}
