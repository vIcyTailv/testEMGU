using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.Util;
using testEMGU.Operator;
using testEMGU.Operator.OperatorParameters;
using testEMGU.OperatorParameters;

namespace testEMGU
{
    public partial class HomeForm : Form
    {
        static Image<Bgr, byte> _ImageInput;
        public HomeForm()
        {
            InitializeComponent();
            //测试，可删
            _ImageInput = new Image<Bgr, byte>(@"C:\Tools\bmpimg\9.bmp");
            imageBox1.Image = _ImageInput;
        }
        public static Image<Bgr, byte> getImageInput()
        {
            return _ImageInput;
        }
        public void showImage(Image<Gray,byte> img)
        {
            imageBox1.Image = img;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _ImageInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = _ImageInput;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to close ?", "System.Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ImageInput == null)
            {
                return;
            }
            imageBox1.Image = _ImageInput;
        }
        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canny canny = new Canny();
            canny.setCannyInput(_ImageInput);
            imageBox1.Image = canny.ApplyCanny();
        }
        private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyParameters cp = new CannyParameters(this,_ImageInput);
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.Show();
        }
        //public void ApplyCanny(double threshold = 50.0, double thresholdLink = 20.0)
        //{
        //    if (_ImageInput == null)
        //    {
        //        return;
        //    }

        //    Image<Gray, byte> imgCanny = new Image<Gray, byte>(_ImageInput.Width, _ImageInput.Height, new Gray(0));
        //    imgCanny = _ImageInput.Canny(threshold, thresholdLink);
        //    imageBox1.Image = imgCanny;
        //}
        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobel sobel = new Sobel();
            sobel.setSobelInput(_ImageInput);
            imageBox1.Image = sobel.ApplySobel();

        }
        private void sobelParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelParameters sp = new SobelParameters(this, _ImageInput);
            sp.StartPosition = FormStartPosition.CenterParent;
            sp.Show();
        }
        //public void ApplySobel(int xorder=1, int yorder =1, int apetureSize =17,int gray_threshold=124, int white_threshold=255)
        //{
        //    if (_ImageInput == null)
        //    {
        //        return;
        //    }
        //    Image<Gray, byte> imgGray = _ImageInput.Convert<Gray, byte>();
        //    Image<Gray, float> imgSobel = new Image<Gray, float>(_ImageInput.Width, _ImageInput.Height, new Gray(0));
        //    imgSobel = imgGray.Sobel(xorder,yorder,apetureSize);
        //    var imgBinarize = imgSobel.Convert<Gray, byte>().ThresholdBinary(new Gray(gray_threshold), new Gray(white_threshold));
        //    imageBox1.Image = imgBinarize;

        //}
        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laplace laplace = new Laplace();
            laplace.setLaplaceInput(_ImageInput);
            imageBox1.Image=laplace.ApplyLaplace();
            
        }
        private void laplaceParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaplaceParameters lp = new LaplaceParameters(this, _ImageInput);
            lp.StartPosition = FormStartPosition.CenterParent;
            lp.Show();
        }
        //public void ApplyLaplace(int apeturesize = 3)
        //{
        //    if (_ImageInput == null)
        //    {
        //        return;
        //    }
        //    Image<Gray, byte> imgGray = _ImageInput.Convert<Gray, byte>();
        //    Image<Gray, float> imgLaplace = new Image<Gray, float>(_ImageInput.Width, _ImageInput.Height, new Gray(0));
        //    imgLaplace = imgGray.Laplace(apeturesize);
        //    imageBox1.Image = imgLaplace;

        //}
        private void dFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DFT dft = new DFT();
            dft.setDFTInput(_ImageInput);
            imageBox1.Image = dft.ApplyDFT();
        }
        //public void ApplyDFT()
        //{
        //    if (_ImageInput == null)
        //    {
        //        return;
        //    }
        //    Image<Gray, float> imgGray = _ImageInput.Convert<Gray, float>();
        //    //int m = CvInvoke.cvGetOptimalDFTSize(imgGray.Rows);
        //    //int n = CvInvoke.cvGetOptimalDFTSize(imgGray.Cols);

        //    IntPtr complexImage = CvInvoke.cvCreateImage(imgGray.Size, Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_32F, 2);
        //    CvInvoke.cvSetZero(complexImage);//initialize all elements to Zero
        //    CvInvoke.cvSetImageCOI(complexImage, 1);
        //    CvInvoke.cvCopy(imgGray, complexImage, IntPtr.Zero);
        //    CvInvoke.cvSetImageCOI(complexImage, 0);
        //    Matrix<float> dft = new Matrix<float>(imgGray.Rows, imgGray.Cols, 2);
        //    CvInvoke.cvDFT(complexImage, dft, Emgu.CV.CvEnum.CV_DXT.CV_DXT_FORWARD, 0);

        //    //The Real part of the Fourier Transform
        //    Matrix<float> outReal = new Matrix<float>(imgGray.Size);
        //    //The imaginary part of the Fourier Transform
        //    Matrix<float> outImaginary = new Matrix<float>(imgGray.Size);
        //    CvInvoke.cvSplit(dft, outReal, outImaginary, IntPtr.Zero, IntPtr.Zero);

        //    CvInvoke.cvPow(outReal, outReal, 2.0);
        //    CvInvoke.cvPow(outImaginary, outImaginary, 2.0);

        //    CvInvoke.cvAdd(outReal, outImaginary, outReal, IntPtr.Zero);
        //    CvInvoke.cvPow(outReal, outReal, 0.5);

        //    CvInvoke.cvAddS(outReal, new MCvScalar(1.0), outReal, IntPtr.Zero); // 1 + Mag
        //    CvInvoke.cvLog(outReal, outReal); // log(1 + Mag)

        //    // Swap quadrants
        //    int cx = outReal.Cols / 2;
        //    int cy = outReal.Rows / 2;

        //    Matrix<float> q0 = outReal.GetSubRect(new Rectangle(0, 0, cx, cy));
        //    Matrix<float> q1 = outReal.GetSubRect(new Rectangle(cx, 0, cx, cy));
        //    Matrix<float> q2 = outReal.GetSubRect(new Rectangle(0, cy, cx, cy));
        //    Matrix<float> q3 = outReal.GetSubRect(new Rectangle(cx, cy, cx, cy));
        //    Matrix<float> tmp = new Matrix<float>(q0.Size);

        //    q0.CopyTo(tmp);
        //    q3.CopyTo(q0);
        //    tmp.CopyTo(q3);
        //    q1.CopyTo(tmp);
        //    q2.CopyTo(q1);
        //    tmp.CopyTo(q2);

        //    CvInvoke.cvNormalize(outReal, outReal, 0.0, 255.0, Emgu.CV.CvEnum.NORM_TYPE.CV_MINMAX, IntPtr.Zero);

        //    Image<Gray, float> fftImage = new Image<Gray, float>(outReal.Size);
        //    CvInvoke.cvCopy(outReal, fftImage, IntPtr.Zero);

        //    imageBox1.Image = fftImage;

        //}
        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = new Gaussian();
            gaussian.setGaussianInput(_ImageInput);
            imageBox1.Image=gaussian.ApplyGaussianBlur();
        }
        private void gaussianParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianParameters gp = new GaussianParameters(this, _ImageInput);
            gp.StartPosition = FormStartPosition.CenterParent;
            gp.Show();
        }
        //public void ApplyGaussianBlur(int size=131,double X=15,double Y=13)
        //{
        //    Image<Gray, float> imgGray = _ImageInput.Convert<Gray, float>();
        //    Image<Gray, float> imgGaussian = new Image<Gray, float>(_ImageInput.Width,_ImageInput.Height);
        //    Mat gaussian = new Mat();
        //    CvInvoke.cvSmooth(imgGray, imgGaussian, SMOOTH_TYPE.CV_GAUSSIAN, size, size, X, Y);
        //    imageBox1.Image = imgGaussian;
        //}
        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation dilation = new Dilation();
            var bitmap = dilation.GetBitmap(_ImageInput);
            var smooth = dilation.Smooth(bitmap);
            imageBox1.Image = new Image<Bgr, Byte>(smooth);
        }
    }

}
