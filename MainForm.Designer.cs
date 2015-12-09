namespace Astrid {
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_parse = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchPath = new System.Windows.Forms.Button();
            this.savePathComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(0, 0);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 13;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(0, 0);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 12;
            // 
            // button_parse
            // 
            this.button_parse.Location = new System.Drawing.Point(0, 0);
            this.button_parse.Name = "button_parse";
            this.button_parse.Size = new System.Drawing.Size(75, 23);
            this.button_parse.TabIndex = 11;
            // 
            // label_time
            // 
            this.label_time.Location = new System.Drawing.Point(0, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(100, 23);
            this.label_time.TabIndex = 10;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(0, 0);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 21);
            this.textBox_height.TabIndex = 0;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(0, 0);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 21);
            this.textBox_width.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // searchPath
            // 
            this.searchPath.Location = new System.Drawing.Point(0, 0);
            this.searchPath.Name = "searchPath";
            this.searchPath.Size = new System.Drawing.Size(75, 23);
            this.searchPath.TabIndex = 0;
            // 
            // savePathComboBox
            // 
            this.savePathComboBox.Location = new System.Drawing.Point(0, 0);
            this.savePathComboBox.Name = "savePathComboBox";
            this.savePathComboBox.Size = new System.Drawing.Size(121, 20);
            this.savePathComboBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 47);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_parse);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "会议视频录制软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_parse;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchPath;
        private System.Windows.Forms.ComboBox savePathComboBox;
        private System.Windows.Forms.Label label4;
    }
}

