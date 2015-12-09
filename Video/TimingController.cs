using System;
using System.Collections.Generic;
using System.Text;
using Astrid.Timing;
using Astrid.Video;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;
namespace Astrid.Video {
    class TimingController {

        private Recorder recorder = new Mp4FileAccessRecorder();
        private List<SimpleTimePeriod> periods = new List<SimpleTimePeriod>();
        private Timer timer = new Timer();
        private bool enabled = false;
        private PictureBox pic = null;


        public TimingController() {
            timer.Interval = 1000;
            timer.Tick += OnTimeChanged;
            timer.Enabled = true;
        }

        public bool Enabled {
            get {
                return enabled;
            }
            set {
                enabled = value;
            }
        }
        public PictureBox Display {
            set {
                pic = value;
            }
        }
        public void AddTimePeriod(SimpleTimePeriod period) {
            periods.Add(period);
        }


        private void OnTimeChanged( object s, EventArgs e) {
            if (enabled) {
                Mp4FileAccessRecorder recorder = (Mp4FileAccessRecorder)this.recorder;
                SimpleTime now = new SimpleTime(System.DateTime.Now);
                periods.ForEach(delegate(SimpleTimePeriod p) {
                    if (now.Equals(p.Start)) {

                        recorder.Initialize(p.ToString());
                        recorder.Start();
                        if (pic != null) {
                            recorder.OnImageCaptured = new ImageDelegate(delegate(Bitmap bitmap) {
                                pic.BackgroundImage = bitmap;
                            });
                        }

                    }
                    else if (now.Equals(p.End)) {
                        recorder.Stop();
                        if (pic != null) {
                            pic.BackgroundImage = null;
                        }

                    }
                });
            }
        }

        
    }
}
