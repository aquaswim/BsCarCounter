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
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace BsCarCounter
{
    public partial class mainForm : Form
    {
        static MCvScalar SCALAR_BLACK = new MCvScalar(0.0, 0.0, 0.0);
        static MCvScalar SCALAR_WHITE = new MCvScalar(255.0, 255.0, 255.0);
        static MCvScalar SCALAR_BLUE = new MCvScalar(255.0, 0.0, 0.0);
        static MCvScalar SCALAR_GREEN = new MCvScalar(0.0, 200.0, 0.0);
        static MCvScalar SCALAR_RED = new MCvScalar(0.0, 0.0, 255.0);
        static MCvScalar SCALAR_YELLOW = new MCvScalar(Color.Yellow.B, Color.Yellow.G, Color.Yellow.R);
        static Mat structuringElement = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));

        BackgroundSubtractorMOG2 bs;
        Rectangle countingLane;
        uint carcount = 0;
        private Point CenterOfRect(Rectangle rect)
        {
            return new Point(rect.Width / 2 + rect.X, rect.Height/2+rect.Y);
        }

        private bool pointCrossLine(Point p,LineSegment2D line)
        {
            int left = Math.Min(line.P1.X, line.P2.X);
            int right = Math.Max(line.P1.X, line.P2.X);
            if (p.X < right && p.X > left)
            {
                return Math.Abs(p.Y - line.P1.Y) < 2;
            }
            else
                return false;
        }

        private void Process(object sender, EventArgs e)
        {
            lblCarCount.Text = carcount.ToString();
            if (bs == null)
                bs = new BackgroundSubtractorMOG2(250, 25, true);
            if (videoCapture != null&&isPlaying)
            {
                if (videoCapture.IsOpened)
                {
                    imgOriginal = videoCapture.QueryFrame();
                    if (imgOriginal != null)
                    {
                        imgResult = imgOriginal.Clone();
                        using (Mat tempimg= imgOriginal.Clone())
                        {
                            imgBS = new Mat();
                            int gaussianBlurSize = tbGaussianBlur.Value % 2 == 0 ? tbGaussianBlur.Value+1 : tbGaussianBlur.Value;
                            CvInvoke.GaussianBlur(tempimg, tempimg, new Size(gaussianBlurSize, gaussianBlurSize), 1.0);
                            bs.Apply(tempimg, imgBS);
                            CvInvoke.Threshold(imgBS, imgBS, tbThreshold.Value, 255, ThresholdType.Binary);
                            switch (cbDilEroOrder.SelectedIndex)
                            {
                                case 0:
                                    CvInvoke.Dilate(imgBS, imgBS, structuringElement, new Point(-1, -1), tbDilateIter.Value, BorderType.Default, new MCvScalar());
                                    CvInvoke.Erode(imgBS, imgBS, structuringElement, new Point(-1, -1), tbErodeIter.Value, BorderType.Default, new MCvScalar());
                                    break;
                                case 1:
                                    CvInvoke.Erode(imgBS, imgBS, structuringElement, new Point(-1, -1), tbErodeIter.Value, BorderType.Default, new MCvScalar());
                                    CvInvoke.Dilate(imgBS, imgBS, structuringElement, new Point(-1, -1), tbDilateIter.Value, BorderType.Default, new MCvScalar());
                                    break;
                            }
                            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                            VectorOfVectorOfPoint filteredContours = new VectorOfVectorOfPoint();
                            countingLane = new Rectangle(tbCountingLanePosX.Value, tbCountingLanePosY.Value, tbCountingLaneSizeWidth.Value, tbCountingLaneSizeHeight.Value);
                            if (cbxCounting.Checked)
                            {
                                CvInvoke.FindContours(imgBS, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);
                                for (int i = 0; i < contours.Size; i++)
                                {
                                    double area = CvInvoke.ContourArea(contours[i]);
                                    if (area > tbMinSize.Value)
                                    {
                                        Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                                        Point middlePoint = CenterOfRect(rect);
                                        CvInvoke.Circle(imgResult, middlePoint, 1, SCALAR_BLUE, 2);
                                        if (countingLane.Contains(middlePoint))
                                        {
                                            CvInvoke.Rectangle(imgResult, rect, SCALAR_RED, 2);
                                            LineSegment2D line = new LineSegment2D();
                                            if (cbxIncoming.Checked)
                                            {
                                                line.P1 = new Point(countingLane.Left, countingLane.Bottom);
                                                line.P2 = new Point(countingLane.Right, countingLane.Bottom);
                                            }
                                            else
                                            {
                                                line.P1 = new Point(countingLane.Left, countingLane.Top);
                                                line.P2 = new Point(countingLane.Right, countingLane.Top);
                                            }
                                            CvInvoke.Line(imgResult, line.P1, line.P2, SCALAR_WHITE, 1);
                                            if (pointCrossLine(middlePoint, line))
                                            {
                                                carcount++;
                                                Console.WriteLine($"Car count: {carcount}");
                                                CvInvoke.Line(imgResult, line.P1, line.P2, SCALAR_YELLOW, 3);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                CvInvoke.Rectangle(imgResult, countingLane, SCALAR_RED, 1);
                                if (cbxIncoming.Checked)
                                {
                                    CvInvoke.Line(imgResult, new Point(countingLane.Left, countingLane.Bottom), new Point(countingLane.Right, countingLane.Bottom), SCALAR_YELLOW, 3);
                                }
                                else
                                {
                                    CvInvoke.Line(imgResult, new Point(countingLane.Left, countingLane.Top), new Point(countingLane.Right, countingLane.Top), SCALAR_YELLOW, 3);
                                }
                            }

                            ibResult.Image = imgResult;
                            ibOriginal.Image = imgOriginal;
                            ibBs.Image = imgBS;
                        }
                    }
                    else
                    {
                        videoCapture.SetCaptureProperty(CapProp.PosFrames, 0.0);
                    }
                }
            }
        }
    }
}
