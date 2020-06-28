using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEMGU.Operator
{
    class DFT
    {
        Image<Bgr, byte> imageInput;
        public Image<Gray, float> ApplyDFT()
        {

            Image<Gray, float> imgGray = imageInput.Convert<Gray, float>();
            //int m = CvInvoke.cvGetOptimalDFTSize(imgGray.Rows);
            //int n = CvInvoke.cvGetOptimalDFTSize(imgGray.Cols);

            IntPtr complexImage = CvInvoke.cvCreateImage(imgGray.Size, Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_32F, 2);
            CvInvoke.cvSetZero(complexImage);//initialize all elements to Zero
            CvInvoke.cvSetImageCOI(complexImage, 1);
            CvInvoke.cvCopy(imgGray, complexImage, IntPtr.Zero);
            CvInvoke.cvSetImageCOI(complexImage, 0);
            Matrix<float> dft = new Matrix<float>(imgGray.Rows, imgGray.Cols, 2);
            CvInvoke.cvDFT(complexImage, dft, Emgu.CV.CvEnum.CV_DXT.CV_DXT_FORWARD, 0);

            //The Real part of the Fourier Transform
            Matrix<float> outReal = new Matrix<float>(imgGray.Size);
            //The imaginary part of the Fourier Transform
            Matrix<float> outImaginary = new Matrix<float>(imgGray.Size);
            CvInvoke.cvSplit(dft, outReal, outImaginary, IntPtr.Zero, IntPtr.Zero);

            CvInvoke.cvPow(outReal, outReal, 2.0);
            CvInvoke.cvPow(outImaginary, outImaginary, 2.0);

            CvInvoke.cvAdd(outReal, outImaginary, outReal, IntPtr.Zero);
            CvInvoke.cvPow(outReal, outReal, 0.5);

            CvInvoke.cvAddS(outReal, new MCvScalar(1.0), outReal, IntPtr.Zero); // 1 + Mag
            CvInvoke.cvLog(outReal, outReal); // log(1 + Mag)

            // Swap quadrants
            int cx = outReal.Cols / 2;
            int cy = outReal.Rows / 2;

            Matrix<float> q0 = outReal.GetSubRect(new Rectangle(0, 0, cx, cy));
            Matrix<float> q1 = outReal.GetSubRect(new Rectangle(cx, 0, cx, cy));
            Matrix<float> q2 = outReal.GetSubRect(new Rectangle(0, cy, cx, cy));
            Matrix<float> q3 = outReal.GetSubRect(new Rectangle(cx, cy, cx, cy));
            Matrix<float> tmp = new Matrix<float>(q0.Size);

            q0.CopyTo(tmp);
            q3.CopyTo(q0);
            tmp.CopyTo(q3);
            q1.CopyTo(tmp);
            q2.CopyTo(q1);
            tmp.CopyTo(q2);

            CvInvoke.cvNormalize(outReal, outReal, 0.0, 255.0, Emgu.CV.CvEnum.NORM_TYPE.CV_MINMAX, IntPtr.Zero);

            Image<Gray, float> fftImage = new Image<Gray, float>(outReal.Size);
            CvInvoke.cvCopy(outReal, fftImage, IntPtr.Zero);

            return fftImage;

        }
        public void setDFTInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }
    }
}
