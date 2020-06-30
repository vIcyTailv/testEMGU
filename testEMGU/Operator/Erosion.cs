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
    class Erosion
    {
        private Image<Bgr, byte> imageInput;
        private Image<Bgr, byte> imageOutput;

        public Image<Bgr,byte> ErosionPic()
        {
            imageOutput = imageInput.Erode(3);
            return imageOutput;
        }
        public void setErosionInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }
    }
}
