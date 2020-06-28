namespace testEMGU
{
    partial class SobelParameters
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
            this.SobelgroupBox = new System.Windows.Forms.GroupBox();
            this.graythreshold_trackBar = new System.Windows.Forms.TrackBar();
            this.whitethreshold_trackbar = new System.Windows.Forms.TrackBar();
            this.whitethreshold_label = new System.Windows.Forms.Label();
            this.graythreshold_label = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.yordernumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.apetureSizenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xordernumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yorderlabel = new System.Windows.Forms.Label();
            this.apetureSizeLabel = new System.Windows.Forms.Label();
            this.xorderlabel = new System.Windows.Forms.Label();
            this.SobelgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graythreshold_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitethreshold_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yordernumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apetureSizenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xordernumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SobelgroupBox
            // 
            this.SobelgroupBox.Controls.Add(this.graythreshold_trackBar);
            this.SobelgroupBox.Controls.Add(this.whitethreshold_trackbar);
            this.SobelgroupBox.Controls.Add(this.whitethreshold_label);
            this.SobelgroupBox.Controls.Add(this.graythreshold_label);
            this.SobelgroupBox.Controls.Add(this.CancelButton);
            this.SobelgroupBox.Controls.Add(this.ApplyButton);
            this.SobelgroupBox.Controls.Add(this.yordernumericUpDown);
            this.SobelgroupBox.Controls.Add(this.apetureSizenumericUpDown);
            this.SobelgroupBox.Controls.Add(this.xordernumericUpDown);
            this.SobelgroupBox.Controls.Add(this.yorderlabel);
            this.SobelgroupBox.Controls.Add(this.apetureSizeLabel);
            this.SobelgroupBox.Controls.Add(this.xorderlabel);
            this.SobelgroupBox.Location = new System.Drawing.Point(12, 12);
            this.SobelgroupBox.Name = "SobelgroupBox";
            this.SobelgroupBox.Size = new System.Drawing.Size(776, 426);
            this.SobelgroupBox.TabIndex = 0;
            this.SobelgroupBox.TabStop = false;
            this.SobelgroupBox.Text = "Sobel";
            // 
            // graythreshold_trackBar
            // 
            this.graythreshold_trackBar.Location = new System.Drawing.Point(298, 247);
            this.graythreshold_trackBar.Maximum = 255;
            this.graythreshold_trackBar.Name = "graythreshold_trackBar";
            this.graythreshold_trackBar.Size = new System.Drawing.Size(325, 80);
            this.graythreshold_trackBar.TabIndex = 11;
            this.graythreshold_trackBar.Value = 124;
            this.graythreshold_trackBar.Scroll += new System.EventHandler(this.graythreshold_trackBar_Scroll);
            // 
            // whitethreshold_trackbar
            // 
            this.whitethreshold_trackbar.Location = new System.Drawing.Point(298, 333);
            this.whitethreshold_trackbar.Maximum = 255;
            this.whitethreshold_trackbar.Name = "whitethreshold_trackbar";
            this.whitethreshold_trackbar.Size = new System.Drawing.Size(325, 80);
            this.whitethreshold_trackbar.TabIndex = 10;
            this.whitethreshold_trackbar.Value = 255;
            this.whitethreshold_trackbar.Scroll += new System.EventHandler(this.whitethreshold_trackbar_Scroll);
            // 
            // whitethreshold_label
            // 
            this.whitethreshold_label.AutoSize = true;
            this.whitethreshold_label.Location = new System.Drawing.Point(6, 333);
            this.whitethreshold_label.Name = "whitethreshold_label";
            this.whitethreshold_label.Size = new System.Drawing.Size(230, 21);
            this.whitethreshold_label.TabIndex = 9;
            this.whitethreshold_label.Text = "White Threshold :255";
            // 
            // graythreshold_label
            // 
            this.graythreshold_label.AutoSize = true;
            this.graythreshold_label.Location = new System.Drawing.Point(17, 250);
            this.graythreshold_label.Name = "graythreshold_label";
            this.graythreshold_label.Size = new System.Drawing.Size(219, 21);
            this.graythreshold_label.TabIndex = 8;
            this.graythreshold_label.Text = "Gray Threshold :124";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(629, 333);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 42);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(629, 250);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(120, 42);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // yordernumericUpDown
            // 
            this.yordernumericUpDown.Location = new System.Drawing.Point(193, 158);
            this.yordernumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.yordernumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yordernumericUpDown.Name = "yordernumericUpDown";
            this.yordernumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.yordernumericUpDown.TabIndex = 5;
            this.yordernumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // apetureSizenumericUpDown
            // 
            this.apetureSizenumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.apetureSizenumericUpDown.Location = new System.Drawing.Point(578, 74);
            this.apetureSizenumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.apetureSizenumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.apetureSizenumericUpDown.Name = "apetureSizenumericUpDown";
            this.apetureSizenumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.apetureSizenumericUpDown.TabIndex = 4;
            this.apetureSizenumericUpDown.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // xordernumericUpDown
            // 
            this.xordernumericUpDown.Location = new System.Drawing.Point(193, 74);
            this.xordernumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.xordernumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xordernumericUpDown.Name = "xordernumericUpDown";
            this.xordernumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.xordernumericUpDown.TabIndex = 3;
            this.xordernumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yorderlabel
            // 
            this.yorderlabel.AutoSize = true;
            this.yorderlabel.Location = new System.Drawing.Point(54, 160);
            this.yorderlabel.Name = "yorderlabel";
            this.yorderlabel.Size = new System.Drawing.Size(98, 21);
            this.yorderlabel.TabIndex = 1;
            this.yorderlabel.Text = "yorder :";
            // 
            // apetureSizeLabel
            // 
            this.apetureSizeLabel.AutoSize = true;
            this.apetureSizeLabel.Location = new System.Drawing.Point(379, 76);
            this.apetureSizeLabel.Name = "apetureSizeLabel";
            this.apetureSizeLabel.Size = new System.Drawing.Size(153, 21);
            this.apetureSizeLabel.TabIndex = 2;
            this.apetureSizeLabel.Text = "apetureSize :";
            // 
            // xorderlabel
            // 
            this.xorderlabel.AutoSize = true;
            this.xorderlabel.Location = new System.Drawing.Point(54, 76);
            this.xorderlabel.Name = "xorderlabel";
            this.xorderlabel.Size = new System.Drawing.Size(98, 21);
            this.xorderlabel.TabIndex = 0;
            this.xorderlabel.Text = "xorder :";
            // 
            // SobelParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SobelgroupBox);
            this.Name = "SobelParameters";
            this.Text = "SobelParameters";
            this.SobelgroupBox.ResumeLayout(false);
            this.SobelgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graythreshold_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitethreshold_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yordernumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apetureSizenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xordernumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SobelgroupBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.NumericUpDown yordernumericUpDown;
        private System.Windows.Forms.NumericUpDown apetureSizenumericUpDown;
        private System.Windows.Forms.NumericUpDown xordernumericUpDown;
        private System.Windows.Forms.Label yorderlabel;
        private System.Windows.Forms.Label apetureSizeLabel;
        private System.Windows.Forms.Label xorderlabel;
        private System.Windows.Forms.Label graythreshold_label;
        private System.Windows.Forms.TrackBar graythreshold_trackBar;
        private System.Windows.Forms.TrackBar whitethreshold_trackbar;
        private System.Windows.Forms.Label whitethreshold_label;
    }
}