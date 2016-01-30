using System;
using System.Collections.Generic;
using System.Text;
using Oraycn.MCapture;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using ESBasic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Astrid.Common.Timing;
namespace Astrid.Video
{

    /// <summary>
    /// 用于图像通知的委托。
    /// </summary>
    /// <param name="image"></param>
    public delegate void ImageDelegate(Bitmap image);


    enum RecorderStatus {
        Recording,
        NotRecording
    }

    /// <summary>
    /// 记录仪，用于视频与音频的同步录制。
    /// </summary>
    class Recorder
    {
        /// <summary>
        /// 默认图像帧率。
        /// </summary>
        public static int DEFAULT_VIDEO_FRAME_RATE = 30;
        /// <summary>
        /// 默认音频采样率。
        /// </summary>
        public static int DEFAULT_AUDIO_SAMPLE_RATE = 16000;
        /// <summary>
        /// 默认图像尺寸。
        /// </summary>
        public static Size DEFAULT_VIDEO_SIZE = new Size(640,480);
        /// <summary>
        /// 默认图像宽度像素数。
        /// </summary>
        public static int DEFAULT_VIDEO_HEIGHT = DEFAULT_VIDEO_SIZE.Height;
        /// <summary>
        /// 默认图像高度像素数。
        /// </summary>
        public static int DEFAULT_VIDEO_WIDTH = DEFAULT_VIDEO_SIZE.Width;
        /// <summary>
        /// 支持的最大实例数。
        /// </summary>
        public static int MAX_INSTANCE_COUNT = 1;

        /// <summary>
        /// 默认图像捕获器。
        /// </summary>
        protected static ICameraCapturer DEFAULT_CAMERA_CAPTURE = CapturerFactory.CreateCameraCapturer(0, new Size(DEFAULT_VIDEO_WIDTH, DEFAULT_VIDEO_HEIGHT), DEFAULT_VIDEO_FRAME_RATE);
        /// <summary>
        /// 默认音频捕获器。
        /// </summary>
        protected static IMicrophoneCapturer DEFAULT_MICROPHONE_CAPTURE = CapturerFactory.CreateMicrophoneCapturer(0);



        /// <summary>
        /// 实例计数器。
        /// </summary>
        private static int instanceCount = 0;


        /// <summary>
        /// 音频捕获设备。
        /// </summary>
        protected IMicrophoneCapturer microphoneCapturer;
        /// <summary>
        /// 图像捕获设备。
        /// </summary>
        protected ICameraCapturer cameraCapturer;
        /// <summary>
        /// 图像宽度像素。
        /// </summary>
        ///protected int videoWidth;
        /// <summary>
        /// 图像高度像素。
        /// </summary>
        ///protected int videoHeight;
        /// <summary>
        /// 帧率。
        /// </summary>
        ///protected int frameRate;
        /// <summary>
        /// 音频采样率。
        /// </summary>
        ///protected int audioSampleRate;

        /// <summary>
        /// 录像计时器。
        /// </summary>
        private SimpleTiming timing;

        private ImageDelegate onImageCaptured;
        /// <summary>
        /// 采集得到的图片帧计数
        /// </summary>
        private int frameCount = 0;
        /// <summary>
        /// 是否正在录像。
        /// </summary>
        protected bool isRecording = false;
        /// <summary>
        /// 当前的一帧图像。
        /// </summary>
        private Bitmap curImg;

        



        /// <summary>
        /// 暂停录制，但并不会停止。在调用该方法之前必须调用Start函数。
        /// </summary>
        public virtual void Pause()
        {
            timing.Pause();
            isRecording = false;
        }
        /// <summary>
        /// 恢复录制。在调用Pause方法后可以调用。
        /// </summary>
        public virtual void Resume() {
            timing.Resume();
            isRecording = true;
        }
        /// <summary>
        /// 启动一次录制，必须调用Stop方法以保存录制的媒体数据。
        /// </summary>
        public virtual void Start()
        {
            timing.ResetTimer();
            this.microphoneCapturer.Start();
            this.cameraCapturer.Start();
            isRecording = true;
        }
        /// <summary>
        /// 在调用该方法之前必须调用Start方法。
        /// </summary>
        public virtual void Stop()
        {
            timing.Pause();
            this.microphoneCapturer.Stop();
            this.cameraCapturer.Stop();
            isRecording = false;
        }

        /// <summary>
        /// 获取录制进程当前的一帧图像，若已暂停录制，则显示最近的一帧。
        /// </summary>
        public Bitmap CurrentImage {
            get { return curImg; }
        }

        public bool IsRecording {
            get {
                return isRecording;       
            }
        }
        public SimpleTiming Timing {
            get {
                return timing;
            }
        }
        public RecorderStatus Status {
            get {
                return IsRecording ? RecorderStatus.Recording : RecorderStatus.NotRecording;
            }
        }

       
        public ImageDelegate OnImageCaptured {
            set {
                onImageCaptured = value;
            }
        }






        /// <summary>
        /// 采用默认设置构造一个记录仪。
        /// </summary>
        public Recorder(ImageDelegate onImgCaptured) {
            instanceCount++;
            if (instanceCount > MAX_INSTANCE_COUNT) {
                throw new ApplicationException("当前仅支持一个记录仪实例。");
            }


            if (DEFAULT_VIDEO_WIDTH % 4 != 0 || DEFAULT_VIDEO_HEIGHT % 4 != 0) {
                throw new Exception("视频长度及宽度必须均设置为4的倍数。");
            }


            timing = new SimpleTiming();
            this.cameraCapturer = DEFAULT_CAMERA_CAPTURE;
            this.cameraCapturer.ImageCaptured += new CbGeneric<Bitmap>(this.OnImageCaptured1);
            this.microphoneCapturer = DEFAULT_MICROPHONE_CAPTURE;
            this.microphoneCapturer.AudioCaptured += OnAudioMixed;

            this.onImageCaptured = onImgCaptured;
        }
        public Recorder():this(null) {
        }

        /// <summary>
        /// 采集到一帧图像的回调函数。
        /// </summary>
        /// <param name="img">当前采集到的图像。</param>
        protected virtual void OnImageCaptured1(Bitmap img)
        {
            this.frameCount++;
            curImg = img;
            onImageCaptured(img);
        }

        /// <summary>
        /// 采集到一帧音频的回调函数。
        /// </summary>
        /// <param name="audioData">音频数据。</param>
        protected virtual void OnAudioMixed(byte[] audioData)
        {
            //DO NOTHING
        }


    }
}
