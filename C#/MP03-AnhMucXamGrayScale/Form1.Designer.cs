namespace MP03_AnhMucXamGrayScale
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
            this.img1_Original = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.img2_Average = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img3_Lightness = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img4_Luminance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặng Thanh Phong - 20146132";
            // 
            // img1_Original
            // 
            this.img1_Original.Location = new System.Drawing.Point(55, 88);
            this.img1_Original.Name = "img1_Original";
            this.img1_Original.Size = new System.Drawing.Size(300, 300);
            this.img1_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_Original.TabIndex = 1;
            this.img1_Original.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average";
            // 
            // img2_Average
            // 
            this.img2_Average.Location = new System.Drawing.Point(427, 88);
            this.img2_Average.Name = "img2_Average";
            this.img2_Average.Size = new System.Drawing.Size(300, 300);
            this.img2_Average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2_Average.TabIndex = 3;
            this.img2_Average.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lightness";
            // 
            // img3_Lightness
            // 
            this.img3_Lightness.Location = new System.Drawing.Point(55, 453);
            this.img3_Lightness.Name = "img3_Lightness";
            this.img3_Lightness.Size = new System.Drawing.Size(300, 300);
            this.img3_Lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3_Lightness.TabIndex = 5;
            this.img3_Lightness.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Luminance";
            // 
            // img4_Luminance
            // 
            this.img4_Luminance.Location = new System.Drawing.Point(427, 453);
            this.img4_Luminance.Name = "img4_Luminance";
            this.img4_Luminance.Size = new System.Drawing.Size(300, 300);
            this.img4_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4_Luminance.TabIndex = 7;
            this.img4_Luminance.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 853);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img4_Luminance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img3_Lightness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img2_Average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img1_Original);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img1_Original;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img2_Average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img3_Lightness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img4_Luminance;
    }
}

