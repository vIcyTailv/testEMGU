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
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.Util;
using testEMGU.Operator.OperatorParameters;
using testEMGU.OperatorParameters;

namespace testEMGU.Operator
{
    public class Canny
    {
        Image<Bgr, byte> imageInput ;
        public Image<Gray, byte> ApplyCanny(double threshold = 50.0, double thresholdLink = 20.0)
        {
            if (imageInput == null)
            {
                MessageBox.Show("no image can be processed");
            }
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imageInput.Width, imageInput.Height, new Gray(0));
            imgCanny = imageInput.Canny(threshold, thresholdLink);
            return imgCanny;
        }
        public void setCannyInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }
    }
}
