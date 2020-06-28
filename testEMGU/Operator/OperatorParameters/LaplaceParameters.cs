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

namespace testEMGU.OperatorParameters
{
    public partial class LaplaceParameters : Form
    {
        HomeForm _homeform;
        Image<Bgr, byte> _imageInput;

        public LaplaceParameters()
        {
            InitializeComponent();
        }
        public LaplaceParameters(HomeForm form,Image<Bgr,byte> input)
        {
            InitializeComponent();
            _homeform = form;
            _imageInput = input;
        }

        private void apeturesize_trackbar_Scroll(object sender, EventArgs e)
        {
            int apeturesize = apeturesize_trackbar.Value;
            apeturesize_label.Text = apeturesize.ToString("ApetureSize :" + apeturesize);
            Laplace laplace = new Laplace();
            laplace.ApplyLaplace(apeturesize);
        }
    } 
}
