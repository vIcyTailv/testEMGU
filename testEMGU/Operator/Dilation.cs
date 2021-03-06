﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEMGU.Operator
{
    class Dilation
    {
        private Image<Bgr, byte> imageInput;
        private Image<Bgr, byte> imageOutput;

        public Image<Bgr, byte> ApplyDilation()
        {
            imageOutput = imageInput.Dilate(3);
            return imageOutput;
        }
        public void setDilationInput(Image<Bgr, byte> input)
        {
            imageInput = input;
        }

    }
}
