using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEMGU.Operator
{
    class Gaussian
    {
        Image<Bgr, byte> imageInput;
        public Image<Gray, byte> ApplyGaussianBlur(int size = 131, double X = 15, double Y = 13)
        {
            Image<Gray, float> imgGray = imageInput.Convert<Gray, float>();
            Image<Gray, float> imgGaussian = new Image<Gray, float>(imageInput.Width, imageInput.Height);
            Mat gaussian = new Mat();
            CvInvoke.cvSmooth(imgGray, imgGaussian, SMOOTH_TYPE.CV_GAUSSIAN, size, size, X, Y);
            var imgGauss = imgGaussian.Convert<Gray, byte>();
            return imgGauss;
        }
        public void setGaussianInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }
    }
}
