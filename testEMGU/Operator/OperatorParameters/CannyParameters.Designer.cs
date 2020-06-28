namespace testEMGU
{
    partial class CannyParameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.numericthresholdlink = new System.Windows.Forms.NumericUpDown();
            this.numericthreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericthresholdlink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericthreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApplyButton);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.numericthresholdlink);
            this.groupBox1.Controls.Add(this.numericthreshold);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canny";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(209, 286);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(120, 55);
            this.ApplyButton.TabIndex = 5;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(408, 286);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 55);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // numericthresholdlink
            // 
            this.numericthresholdlink.Location = new System.Drawing.Point(408, 159);
            this.numericthresholdlink.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericthresholdlink.Name = "numericthresholdlink";
            this.numericthresholdlink.Size = new System.Drawing.Size(120, 31);
            this.numericthresholdlink.TabIndex = 3;
            this.numericthresholdlink.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericthreshold
            // 
            this.numericthreshold.Location = new System.Drawing.Point(408, 73);
            this.numericthreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericthreshold.Name = "numericthreshold";
            this.numericthreshold.Size = new System.Drawing.Size(120, 31);
            this.numericthreshold.TabIndex = 2;
            this.numericthreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ThresholdLink :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Threshold :";
            // 
            // CannyParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CannyParameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericthresholdlink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericthreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericthresholdlink;
        private System.Windows.Forms.NumericUpDown numericthreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
    }
}