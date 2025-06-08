namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.lowpass = new System.Windows.Forms.Button();
            this.gaussian = new System.Windows.Forms.Button();
            this.laplace = new System.Windows.Forms.Button();
            this.highpass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(688, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 396);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(454, 87);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 2;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // lowpass
            // 
            this.lowpass.Location = new System.Drawing.Point(454, 233);
            this.lowpass.Name = "lowpass";
            this.lowpass.Size = new System.Drawing.Size(75, 23);
            this.lowpass.TabIndex = 3;
            this.lowpass.Text = "MeanLowPass";
            this.lowpass.UseVisualStyleBackColor = true;
            this.lowpass.Click += new System.EventHandler(this.lowpass_Click);
            // 
            // gaussian
            // 
            this.gaussian.Location = new System.Drawing.Point(454, 297);
            this.gaussian.Name = "gaussian";
            this.gaussian.Size = new System.Drawing.Size(75, 23);
            this.gaussian.TabIndex = 4;
            this.gaussian.Text = "Gaussianfilte";
            this.gaussian.UseVisualStyleBackColor = true;
            // 
            // laplace
            // 
            this.laplace.Location = new System.Drawing.Point(454, 166);
            this.laplace.Name = "laplace";
            this.laplace.Size = new System.Drawing.Size(75, 23);
            this.laplace.TabIndex = 5;
            this.laplace.Text = "laplacianfilter";
            this.laplace.UseVisualStyleBackColor = true;
            this.laplace.Click += new System.EventHandler(this.laplace_Click);
            // 
            // highpass
            // 
            this.highpass.Location = new System.Drawing.Point(454, 388);
            this.highpass.Name = "highpass";
            this.highpass.Size = new System.Drawing.Size(75, 23);
            this.highpass.TabIndex = 6;
            this.highpass.Text = "highpass";
            this.highpass.UseVisualStyleBackColor = true;
            this.highpass.Click += new System.EventHandler(this.highpass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lab 3 Spatial Filtering: Applying filters such as averaging (Mean or Lowpas) ,Hih" +
                "hpass and Gaussian to smooth images and redue noise of";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highpass);
            this.Controls.Add(this.laplace);
            this.Controls.Add(this.gaussian);
            this.Controls.Add(this.lowpass);
            this.Controls.Add(this.load);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button lowpass;
        private System.Windows.Forms.Button gaussian;
        private System.Windows.Forms.Button laplace;
        private System.Windows.Forms.Button highpass;
        private System.Windows.Forms.Label label1;

    }
}

