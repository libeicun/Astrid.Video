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
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPath = new System.Windows.Forms.Button();
            this.savePathComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timePicStart = new System.Windows.Forms.DateTimePicker();
            this.timePicEnd = new System.Windows.Forms.DateTimePicker();
            this.cmdAddPeriod = new System.Windows.Forms.Button();
            this.gpAddPeriod = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAddedPeriods = new System.Windows.Forms.ListView();
            this.gpAddedPeriods = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.prgRecording = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpAddPeriod.SuspendLayout();
            this.gpAddedPeriods.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(6, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(187, 52);
            this.lblTime.TabIndex = 14;
            // 
            // timePicStart
            // 
            this.timePicStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicStart.Location = new System.Drawing.Point(65, 21);
            this.timePicStart.Name = "timePicStart";
            this.timePicStart.Size = new System.Drawing.Size(73, 21);
            this.timePicStart.TabIndex = 15;
            // 
            // timePicEnd
            // 
            this.timePicEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicEnd.Location = new System.Drawing.Point(65, 48);
            this.timePicEnd.Name = "timePicEnd";
            this.timePicEnd.Size = new System.Drawing.Size(73, 21);
            this.timePicEnd.TabIndex = 16;
            // 
            // cmdAddPeriod
            // 
            this.cmdAddPeriod.Location = new System.Drawing.Point(6, 75);
            this.cmdAddPeriod.Name = "cmdAddPeriod";
            this.cmdAddPeriod.Size = new System.Drawing.Size(132, 21);
            this.cmdAddPeriod.TabIndex = 17;
            this.cmdAddPeriod.Text = "添加并立即生效";
            this.cmdAddPeriod.UseVisualStyleBackColor = true;
            this.cmdAddPeriod.Click += new System.EventHandler(this.cmdAddPeriod_Click);
            // 
            // gpAddPeriod
            // 
            this.gpAddPeriod.Controls.Add(this.label5);
            this.gpAddPeriod.Controls.Add(this.label1);
            this.gpAddPeriod.Controls.Add(this.cmdAddPeriod);
            this.gpAddPeriod.Controls.Add(this.timePicStart);
            this.gpAddPeriod.Controls.Add(this.timePicEnd);
            this.gpAddPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpAddPeriod.Location = new System.Drawing.Point(13, 12);
            this.gpAddPeriod.Name = "gpAddPeriod";
            this.gpAddPeriod.Size = new System.Drawing.Size(144, 102);
            this.gpAddPeriod.TabIndex = 18;
            this.gpAddPeriod.TabStop = false;
            this.gpAddPeriod.Text = "添加自动记录时段";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "结束时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "开始时间";
            // 
            // lstAddedPeriods
            // 
            this.lstAddedPeriods.CheckBoxes = true;
            this.lstAddedPeriods.HoverSelection = true;
            this.lstAddedPeriods.Location = new System.Drawing.Point(8, 20);
            this.lstAddedPeriods.Name = "lstAddedPeriods";
            this.lstAddedPeriods.Scrollable = false;
            this.lstAddedPeriods.ShowGroups = false;
            this.lstAddedPeriods.Size = new System.Drawing.Size(347, 97);
            this.lstAddedPeriods.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstAddedPeriods.TabIndex = 19;
            this.lstAddedPeriods.UseCompatibleStateImageBehavior = false;
            // 
            // gpAddedPeriods
            // 
            this.gpAddedPeriods.Controls.Add(this.lstAddedPeriods);
            this.gpAddedPeriods.Location = new System.Drawing.Point(7, 202);
            this.gpAddedPeriods.Name = "gpAddedPeriods";
            this.gpAddedPeriods.Size = new System.Drawing.Size(361, 124);
            this.gpAddedPeriods.TabIndex = 20;
            this.gpAddedPeriods.TabStop = false;
            this.gpAddedPeriods.Text = "已生效的自动记录时段";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(13, 137);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(349, 59);
            this.txtLogs.TabIndex = 21;
            // 
            // prgRecording
            // 
            this.prgRecording.Location = new System.Drawing.Point(64, 75);
            this.prgRecording.Name = "prgRecording";
            this.prgRecording.Size = new System.Drawing.Size(129, 19);
            this.prgRecording.TabIndex = 22;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(6, 79);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(53, 12);
            this.lblProgress.TabIndex = 23;
            this.lblProgress.Text = "录制进度";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblProgress);
            this.groupBox1.Controls.Add(this.prgRecording);
            this.groupBox1.Location = new System.Drawing.Point(163, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态信息";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.gpAddedPeriods);
            this.Controls.Add(this.gpAddPeriod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Watcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gpAddPeriod.ResumeLayout(false);
            this.gpAddPeriod.PerformLayout();
            this.gpAddedPeriods.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchPath;
        private System.Windows.Forms.ComboBox savePathComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker timePicStart;
        private System.Windows.Forms.DateTimePicker timePicEnd;
        private System.Windows.Forms.Button cmdAddPeriod;
        private System.Windows.Forms.GroupBox gpAddPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstAddedPeriods;
        private System.Windows.Forms.GroupBox gpAddedPeriods;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.ProgressBar prgRecording;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

