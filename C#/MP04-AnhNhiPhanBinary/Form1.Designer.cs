namespace MP04_AnhNhiPhanBinary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img1_Original = new System.Windows.Forms.PictureBox();
            this.img2_Average = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.img3_Lightness = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img4_Luminance = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img5_Binary = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CrollNguongBinary = new System.Windows.Forms.VScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.NguongBin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4_Luminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5_Binary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặng Thanh Phong - 20146132";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Original Image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // img1_Original
            // 
            this.img1_Original.Location = new System.Drawing.Point(24, 75);
            this.img1_Original.Name = "img1_Original";
            this.img1_Original.Size = new System.Drawing.Size(300, 300);
            this.img1_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_Original.TabIndex = 2;
            this.img1_Original.TabStop = false;
            // 
            // img2_Average
            // 
            this.img2_Average.Location = new System.Drawing.Point(364, 75);
            this.img2_Average.Name = "img2_Average";
            this.img2_Average.Size = new System.Drawing.Size(300, 300);
            this.img2_Average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2_Average.TabIndex = 4;
            this.img2_Average.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average Image";
            // 
            // img3_Lightness
            // 
            this.img3_Lightness.Location = new System.Drawing.Point(24, 436);
            this.img3_Lightness.Name = "img3_Lightness";
            this.img3_Lightness.Size = new System.Drawing.Size(300, 300);
            this.img3_Lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3_Lightness.TabIndex = 6;
            this.img3_Lightness.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lightness Image";
            // 
            // img4_Luminance
            // 
            this.img4_Luminance.Location = new System.Drawing.Point(364, 436);
            this.img4_Luminance.Name = "img4_Luminance";
            this.img4_Luminance.Size = new System.Drawing.Size(300, 300);
            this.img4_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4_Luminance.TabIndex = 8;
            this.img4_Luminance.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Luminance Image";
            // 
            // img5_Binary
            // 
            this.img5_Binary.Location = new System.Drawing.Point(705, 75);
            this.img5_Binary.Name = "img5_Binary";
            this.img5_Binary.Size = new System.Drawing.Size(300, 300);
            this.img5_Binary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img5_Binary.TabIndex = 10;
            this.img5_Binary.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Binary Image";
            // 
            // CrollNguongBinary
            // 
            this.CrollNguongBinary.Location = new System.Drawing.Point(1058, 75);
            this.CrollNguongBinary.Maximum = 255;
            this.CrollNguongBinary.Name = "CrollNguongBinary";
            this.CrollNguongBinary.Size = new System.Drawing.Size(30, 300);
            this.CrollNguongBinary.TabIndex = 11;
            this.CrollNguongBinary.ValueChanged += new System.EventHandler(this.CrollNguongBinary_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1039, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Threshold";
            // 
            // NguongBin
            // 
            this.NguongBin.AutoSize = true;
            this.NguongBin.Location = new System.Drawing.Point(1102, 94);
            this.NguongBin.Name = "NguongBin";
            this.NguongBin.Size = new System.Drawing.Size(0, 16);
            this.NguongBin.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 853);
            this.Controls.Add(this.NguongBin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CrollNguongBinary);
            this.Controls.Add(this.img5_Binary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.img4_Luminance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img3_Lightness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img2_Average);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img1_Original);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4_Luminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5_Binary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img1_Original;
        private System.Windows.Forms.PictureBox img2_Average;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img3_Lightness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img4_Luminance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img5_Binary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.VScrollBar CrollNguongBinary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NguongBin;
    }
}

