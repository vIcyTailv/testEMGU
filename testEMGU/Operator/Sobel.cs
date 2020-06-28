using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEMGU.Operator
{
    public class Sobel
    {
        Image<Bgr, byte> imageInput = HomeForm.getImageInput();
        public Image<Gray, byte> ApplySobel(int xorder = 1, int yorder = 1, int apetureSize = 17, int gray_threshold = 124, int white_threshold = 255)
        {
            if (imageInput == null)
            {
                MessageBox.Show("no imaage can be processed");
            }
            Image<Gray, byte> imgGray = imageInput.Convert<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray, float>(imageInput.Width, imageInput.Height, new Gray(0));
            imgSobel = imgGray.Sobel(xorder, yorder, apetureSize);
            var imgBinarize = imgSobel.Convert<Gray, byte>().ThresholdBinary(new Gray(gray_threshold), new Gray(white_threshold));
            return imgBinarize;
        }
        public void setSobelInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }
    }
}
