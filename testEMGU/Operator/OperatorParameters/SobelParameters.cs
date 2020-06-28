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
    public partial class SobelParameters : Form
    {
        HomeForm _homeform;
        Image<Bgr, byte> imageInput;
        Sobel sobel = new Sobel();
        int _gray_threshold, _white_threshold;
        public SobelParameters()
        {
            InitializeComponent();
        }
        public SobelParameters(HomeForm form,Image<Bgr,byte> input)
        {
            InitializeComponent();
            _homeform = form;
            imageInput = input;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void whitethreshold_trackbar_Scroll(object sender, EventArgs e)
        {

            _white_threshold = whitethreshold_trackbar.Value;
            whitethreshold_label.Text = "White Threshold :" + _white_threshold.ToString();
            _homeform.showImage(sobel.ApplySobel((int)xordernumericUpDown.Value, (int)yordernumericUpDown.Value, (int)apetureSizenumericUpDown.Value, _gray_threshold, _white_threshold));
        }
        private void graythreshold_trackBar_Scroll(object sender, EventArgs e)
        {
            _gray_threshold = graythreshold_trackBar.Value;
            graythreshold_label.Text = "Gray Threshold :" + _gray_threshold.ToString();
            _homeform.showImage(sobel.ApplySobel((int)xordernumericUpDown.Value, (int)yordernumericUpDown.Value, (int)apetureSizenumericUpDown.Value, _gray_threshold, _white_threshold));
        }
        private void ApplyButton_Click(object sender, EventArgs e)
        {

            if (_homeform != null)
            {
                try
                {
                    sobel.ApplySobel((int)xordernumericUpDown.Value, (int)yordernumericUpDown.Value, (int)apetureSizenumericUpDown.Value, _gray_threshold, _white_threshold);
                }
                catch
                {
                    MessageBox.Show("invalid number! apetureSize must be bigger than xorder and yorder and be odd.");
                }

            }

        }

    }
}
