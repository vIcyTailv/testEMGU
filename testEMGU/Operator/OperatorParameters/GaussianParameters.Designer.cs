namespace testEMGU.Operator.OperatorParameters
{
    partial class GaussianParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GaussiangroupBox = new System.Windows.Forms.GroupBox();
            this.Sizelabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.SizetrackBar = new System.Windows.Forms.TrackBar();
            this.XtrackBar = new System.Windows.Forms.TrackBar();
            this.YtrackBar = new System.Windows.Forms.TrackBar();
            this.tipslabel = new System.Windows.Forms.Label();
            this.GaussiangroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizetrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GaussiangroupBox
            // 
            this.GaussiangroupBox.Controls.Add(this.tipslabel);
            this.GaussiangroupBox.Controls.Add(this.YtrackBar);
            this.GaussiangroupBox.Controls.Add(this.XtrackBar);
            this.GaussiangroupBox.Controls.Add(this.SizetrackBar);
            this.GaussiangroupBox.Controls.Add(this.Ylabel);
            this.GaussiangroupBox.Controls.Add(this.Xlabel);
            this.GaussiangroupBox.Controls.Add(this.Sizelabel);
            this.GaussiangroupBox.Location = new System.Drawing.Point(13, 13);
            this.GaussiangroupBox.Name = "GaussiangroupBox";
            this.GaussiangroupBox.Size = new System.Drawing.Size(775, 425);
            this.GaussiangroupBox.TabIndex = 0;
            this.GaussiangroupBox.TabStop = false;
            this.GaussiangroupBox.Text = "Gaussian";
            // 
            // Sizelabel
            // 
            this.Sizelabel.AutoSize = true;
            this.Sizelabel.Location = new System.Drawing.Point(39, 59);
            this.Sizelabel.Name = "Sizelabel";
            this.Sizelabel.Size = new System.Drawing.Size(87, 21);
            this.Sizelabel.TabIndex = 0;
            this.Sizelabel.Text = "kSize :";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(83, 137);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(43, 21);
            this.Xlabel.TabIndex = 1;
            this.Xlabel.Text = "X :";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(83, 217);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(43, 21);
            this.Ylabel.TabIndex = 2;
            this.Ylabel.Text = "Y :";
            // 
            // SizetrackBar
            // 
            this.SizetrackBar.LargeChange = 10;
            this.SizetrackBar.Location = new System.Drawing.Point(198, 59);
            this.SizetrackBar.Maximum = 99;
            this.SizetrackBar.Minimum = 3;
            this.SizetrackBar.Name = "SizetrackBar";
            this.SizetrackBar.Size = new System.Drawing.Size(422, 80);
            this.SizetrackBar.SmallChange = 2;
            this.SizetrackBar.TabIndex = 3;
            this.SizetrackBar.Value = 3;
            this.SizetrackBar.Scroll += new System.EventHandler(this.SizetrackBar_Scroll);
            // 
            // XtrackBar
            // 
            this.XtrackBar.LargeChange = 10;
            this.XtrackBar.Location = new System.Drawing.Point(198, 137);
            this.XtrackBar.Maximum = 100;
            this.XtrackBar.Name = "XtrackBar";
            this.XtrackBar.Size = new System.Drawing.Size(422, 80);
            this.XtrackBar.TabIndex = 4;
            this.XtrackBar.Scroll += new System.EventHandler(this.XtrackBar_Scroll);
            // 
            // YtrackBar
            // 
            this.YtrackBar.LargeChange = 10;
            this.YtrackBar.Location = new System.Drawing.Point(198, 217);
            this.YtrackBar.Maximum = 100;
            this.YtrackBar.Name = "YtrackBar";
            this.YtrackBar.Size = new System.Drawing.Size(422, 80);
            this.YtrackBar.TabIndex = 5;
            this.YtrackBar.Scroll += new System.EventHandler(this.YtrackBar_Scroll);
            // 
            // tipslabel
            // 
            this.tipslabel.AutoSize = true;
            this.tipslabel.Location = new System.Drawing.Point(83, 313);
            this.tipslabel.Name = "tipslabel";
            this.tipslabel.Size = new System.Drawing.Size(615, 21);
            this.tipslabel.TabIndex = 6;
            this.tipslabel.Text = "Tips: ksize must bigger than zero and ksize must be odd";
            // 
            // GaussianParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GaussiangroupBox);
            this.Name = "GaussianParameters";
            this.Text = "GaussianParameters";
            this.GaussiangroupBox.ResumeLayout(false);
            this.GaussiangroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizetrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YtrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GaussiangroupBox;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Sizelabel;
        private System.Windows.Forms.TrackBar YtrackBar;
        private System.Windows.Forms.TrackBar XtrackBar;
        private System.Windows.Forms.TrackBar SizetrackBar;
        private System.Windows.Forms.Label tipslabel;
    }
}