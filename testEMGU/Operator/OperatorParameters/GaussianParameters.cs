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

namespace testEMGU.Operator.OperatorParameters
{
    public partial class GaussianParameters : Form
    {
        HomeForm _homeform;
        Image<Bgr, byte> imageInput;
        Gaussian gaussian = new Gaussian();
        int _sizeValue, _xValue, _yValue;
        public GaussianParameters()
        {
            InitializeComponent();
        }
        public GaussianParameters(HomeForm form, Image<Bgr, byte> input)
        {
            InitializeComponent();
            _homeform = form;
            imageInput = input;
        }
        private void SizetrackBar_Scroll(object sender, EventArgs e)
        {
            _sizeValue = SizetrackBar.Value;
            Sizelabel.Text = ("kSize : ") + _sizeValue.ToString();

            _homeform.showImage(gaussian.ApplyGaussianBlur(_sizeValue, _xValue, _yValue));
        }
        private void XtrackBar_Scroll(object sender, EventArgs e)
        {
            _xValue = XtrackBar.Value;
            Xlabel.Text = ("X : ") + _xValue.ToString();
            _homeform.showImage(gaussian.ApplyGaussianBlur(_sizeValue, _xValue, _yValue));
        }

        private void YtrackBar_Scroll(object sender, EventArgs e)
        {
            _yValue = YtrackBar.Value;
            Ylabel.Text = ("Y : ") + _yValue.ToString();
            _homeform.showImage(gaussian.ApplyGaussianBlur(_sizeValue, _xValue, _yValue));
        }
    }
}
