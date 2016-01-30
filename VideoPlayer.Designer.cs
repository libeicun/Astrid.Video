namespace Astrid {
    partial class VideoPlayer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.picDisplayVideo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplayVideo
            // 
            this.picDisplayVideo.BackColor = System.Drawing.Color.Black;
            this.picDisplayVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDisplayVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDisplayVideo.Location = new System.Drawing.Point(0, -1);
            this.picDisplayVideo.Name = "picDisplayVideo";
            this.picDisplayVideo.Size = new System.Drawing.Size(284, 262);
            this.picDisplayVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplayVideo.TabIndex = 9;
            this.picDisplayVideo.TabStop = false;
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picDisplayVideo);
            this.Name = "VideoPlayer";
            this.Text = "VideoPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VideoPlayer_FormClosed);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.Shown += new System.EventHandler(this.VideoPlayer_Shown);
            this.VisibleChanged += new System.EventHandler(this.VideoPlayer_VisibleChanged);
            this.Resize += new System.EventHandler(this.VideoPlayer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplayVideo;
    }
}