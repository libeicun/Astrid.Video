using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Astrid {

    public delegate void OnPlayingStatusChanged(bool isPlaying);

    public partial class VideoPlayer : Form {
        private OnPlayingStatusChanged onStatusChanged;
        private bool isDisplaying;
        public VideoPlayer() {
            InitializeComponent();
            SyncTheSize();
        }

        public bool IsDisplaying {
            get {
                return this.isDisplaying;
            }
        }


        private void VideoPlayer_Load(object sender, EventArgs e) {

        }


        public PictureBox ImageDisplay {
            get {
                return picDisplayVideo;
            }
        }
        public OnPlayingStatusChanged OnPlayingStatusChanged {
            set {
                onStatusChanged = value;
            }
        }

        private void VideoPlayer_Resize(object sender, EventArgs e) {
            SyncTheSize();
        }

        private void SyncTheSize() {
            picDisplayVideo.Size = this.Size;
            picDisplayVideo.Location = this.Location;
        }

        private void VideoPlayer_VisibleChanged(object sender, EventArgs e) {
            if (onStatusChanged != null) {
                onStatusChanged(this.Visible);
            }
        }

        private void VideoPlayer_FormClosed(object sender, FormClosedEventArgs e) {
            isDisplaying = false;
        }

        private void VideoPlayer_Shown(object sender, EventArgs e) {
            isDisplaying = true;
        }

        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e) {
            return;
        }
    }
}
