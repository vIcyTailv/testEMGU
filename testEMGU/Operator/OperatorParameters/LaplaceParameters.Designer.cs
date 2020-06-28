namespace testEMGU.OperatorParameters
{
    partial class LaplaceParameters
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
            this.laplace_groupbox = new System.Windows.Forms.GroupBox();
            this.apeturesize_trackbar = new System.Windows.Forms.TrackBar();
            this.apeturesize_label = new System.Windows.Forms.Label();
            this.laplace_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apeturesize_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // laplace_groupbox
            // 
            this.laplace_groupbox.Controls.Add(this.apeturesize_trackbar);
            this.laplace_groupbox.Controls.Add(this.apeturesize_label);
            this.laplace_groupbox.Location = new System.Drawing.Point(13, 13);
            this.laplace_groupbox.Name = "laplace_groupbox";
            this.laplace_groupbox.Size = new System.Drawing.Size(775, 425);
            this.laplace_groupbox.TabIndex = 0;
            this.laplace_groupbox.TabStop = false;
            this.laplace_groupbox.Text = " Laplace";
            // 
            // apeturesize_trackbar
            // 
            this.apeturesize_trackbar.LargeChange = 6;
            this.apeturesize_trackbar.Location = new System.Drawing.Point(333, 96);
            this.apeturesize_trackbar.Maximum = 31;
            this.apeturesize_trackbar.Minimum = 1;
            this.apeturesize_trackbar.Name = "apeturesize_trackbar";
            this.apeturesize_trackbar.Size = new System.Drawing.Size(380, 80);
            this.apeturesize_trackbar.SmallChange = 2;
            this.apeturesize_trackbar.TabIndex = 1;
            this.apeturesize_trackbar.Value = 1;
            this.apeturesize_trackbar.Scroll += new System.EventHandler(this.apeturesize_trackbar_Scroll);
            // 
            // apeturesize_label
            // 
            this.apeturesize_label.AutoSize = true;
            this.apeturesize_label.Location = new System.Drawing.Point(62, 96);
            this.apeturesize_label.Name = "apeturesize_label";
            this.apeturesize_label.Size = new System.Drawing.Size(174, 21);
            this.apeturesize_label.TabIndex = 0;
            this.apeturesize_label.Text = " ApetureSize ：";
            // 
            // LaplaceParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laplace_groupbox);
            this.Name = "LaplaceParameters";
            this.Text = "LaplaceParameters";
            this.laplace_groupbox.ResumeLayout(false);
            this.laplace_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apeturesize_trackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox laplace_groupbox;
        private System.Windows.Forms.Label apeturesize_label;
        private System.Windows.Forms.TrackBar apeturesize_trackbar;
    }
}