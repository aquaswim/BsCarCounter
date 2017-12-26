using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.VideoSurveillance;

namespace BsCarCounter
{
    public partial class mainForm : Form
    {
        VideoCapture videoCapture;
        Mat imgOriginal;
        Mat imgBS;
        Mat imgResult;
        Timer timer;

        bool isPlaying;
        public mainForm()
        {
            InitializeComponent();
            lblFIle.Text = "";
            Application.Idle += Application_Idle;
            timer = new Timer();
            timer.Interval = tbUpdateInterval.Value;
            timer.Tick += Process;
            timer.Start();
            isPlaying = false;
            toggleControl(false);
            cbDilEroOrder.SelectedIndex = 0;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                if (videoCapture.IsOpened)
                {
                    updateSeekBar();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdVideo.ShowDialog() == DialogResult.OK)
            {
                lblFIle.Text = ofdVideo.FileName;
                videoCapture = new VideoCapture(lblFIle.Text);
                try
                {
                    toggleControl(true);
                    updateSeekBar();
                    initCountingLaneTrackbar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void initCountingLaneTrackbar()
        {
            tbCountingLanePosX.Maximum = videoCapture.Width;
            tbCountingLanePosY.Maximum = videoCapture.Height;
            ReCalcTrackBarCountingLane(this, new EventArgs());

        }

        private void updateSeekBar()
        {
            if (videoCapture != null)
            {
                tbVideoSeek.Maximum = (int)videoCapture.GetCaptureProperty(CapProp.FrameCount);
                tbVideoSeek.Value=(int)videoCapture.GetCaptureProperty(CapProp.PosFrames);
            }
        }

        private void toggleControl(bool value)
        {
            tbVideoSeek.Enabled = value;
            btnLoad.Enabled = !value;
            btnPlayPause.Enabled = value;
            tbUpdateInterval.Enabled = value;
            tbGaussianBlur.Enabled = value;
            tbDilateIter.Enabled = value;
            tbErodeIter.Enabled = value;
            cbDilEroOrder.Enabled = value;
            tbThreshold.Enabled = value;
            cbxCounting.Enabled = value;
            cbxIncoming.Enabled = value;
            tbCountingLanePosX.Enabled = value;
            tbCountingLanePosY.Enabled = value;
            tbCountingLaneSizeHeight.Enabled = value;
            tbCountingLaneSizeWidth.Enabled = value;
            tbMinSize.Enabled = value;
        }

        private void tbUpdateInterval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = tbUpdateInterval.Value;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
        }

        private void ReCalcTrackBarCountingLane(object sender, EventArgs e)
        {
            tbCountingLaneSizeWidth.Maximum = videoCapture.Width - tbCountingLanePosX.Value;
            tbCountingLaneSizeHeight.Maximum = videoCapture.Height - tbCountingLanePosY.Value;
        }
    }
}
