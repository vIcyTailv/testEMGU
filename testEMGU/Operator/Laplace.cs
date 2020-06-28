using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEMGU.Operator
{
    public class Laplace
    {
        Image<Bgr, byte> imageInput;
        public Image<Gray, float> ApplyLaplace(int apeturesize = 3)
        {
            Image<Gray, byte> imgGray = imageInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplace = new Image<Gray, float>(imageInput.Width, imageInput.Height, new Gray(0));
            imgLaplace = imgGray.Laplace(apeturesize);
            return imgLaplace;
        }
        public void setLaplaceInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }
    }
}
