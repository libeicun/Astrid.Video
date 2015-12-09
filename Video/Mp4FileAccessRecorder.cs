using System;
using System.Collections.Generic;
using System.Text;
using Oraycn.MFile;
using System.Drawing;


namespace Astrid.Video
{
    /// <summary>
    /// 记录仪，录制完成后可将媒体文件保存到MP4文件。
    /// </summary>
    class Mp4FileAccessRecorder : Recorder
    {

        protected static string DEFAULT_WORKING_DIRECTORY = Environment.CurrentDirectory + "\\Captured_Videos";
        protected static string DEFAULT_EXTENSION = ".mp4";
        /// <summary>
        /// 工作目录，所有录制的视频文件将保存在此处。
        /// </summary>
        protected static string workingDirectory = DEFAULT_WORKING_DIRECTORY;

        /// <summary>
        /// 
        /// </summary>
        private VideoFileMaker videoFileMaker;





        protected String fileName;
        
        public Mp4FileAccessRecorder() : base()
        {
            this.videoFileMaker = new VideoFileMaker();
        }




        protected override void OnAudioMixed(byte[] audioData)
        {
            base.OnAudioMixed(audioData);
            this.videoFileMaker.AddAudioFrame(audioData);
        }
        protected override void OnImageCaptured1(Bitmap img)
        {
            base.OnImageCaptured1((Bitmap)img.Clone());
            this.videoFileMaker.AddVideoFrame(img);
        }


        public void Initialize(string fileName) {

            isRecording = false;

            this.fileName = fileName;

            if (!System.IO.Directory.Exists(workingDirectory)) {
                System.IO.Directory.CreateDirectory(workingDirectory);
            }

            string filePath = workingDirectory + "\\" + fileName + DEFAULT_EXTENSION;


            this.videoFileMaker.Initialize(filePath, VideoCodecType.H264, DEFAULT_VIDEO_WIDTH, DEFAULT_VIDEO_HEIGHT, DEFAULT_VIDEO_FRAME_RATE, VideoQuality.High, AudioCodecType.AAC, DEFAULT_AUDIO_SAMPLE_RATE, 1, true);

        }
        public override void Start()
        {
            base.Start();
        }

        public override void Stop()
        {
            
            if (isRecording) {

                try {
                    this.videoFileMaker.Close(true);
                }
                catch (Exception e) {
                    System.Console.WriteLine("写入视频文件时发生异常: " + fileName + DEFAULT_EXTENSION);
                }
                

            }
            base.Stop();
            System.GC.Collect();
            
        }

        /// <summary>
        /// 获取当前工作目录。
        /// </summary>
        public static string Directory {
            get {
                return workingDirectory;
            }
            set {
                if (value.EndsWith("\\")) {
                    throw new ApplicationException("请将路径名末尾的\\删除");
                }
                if (value.Contains(":")) {
                    throw new ApplicationException("不应省略路径名中的盘符。");
                }
                workingDirectory = value;
            }
        }


    }
}      
    