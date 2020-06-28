using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testEMGU.Operator;

namespace testEMGU
{
    public partial class CannyParameters : Form
    {
        HomeForm _homeform;
        Image<Bgr, byte> imageInput;
        public CannyParameters()
        {
            InitializeComponent();
        }
        public CannyParameters(HomeForm homeform,Image<Bgr,byte> input)
        {
            InitializeComponent();
            _homeform = homeform;
            imageInput = input;
        }
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Canny canny = new Canny();
            canny.setCannyInput(imageInput);
            _homeform.showImage(canny.ApplyCanny((double)numericthreshold.Value, (double)numericthresholdlink.Value));
        }
    }
}
