namespace MP12_LamSacNetAnhMau
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
            this.img2_Sharpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Sharpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặng Thanh Phong - 20146132";
            // 
            // img1_Original
            // 
            this.img1_Original.Location = new System.Drawing.Point(58, 117);
            this.img1_Original.Name = "img1_Original";
            this.img1_Original.Size = new System.Drawing.Size(512, 512);
            this.img1_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_Original.TabIndex = 1;
            this.img1_Original.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sharpened - Image";
            // 
            // img2_Sharpen
            // 
            this.img2_Sharpen.Location = new System.Drawing.Point(616, 117);
            this.img2_Sharpen.Name = "img2_Sharpen";
            this.img2_Sharpen.Size = new System.Drawing.Size(512, 512);
            this.img2_Sharpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2_Sharpen.TabIndex = 3;
            this.img2_Sharpen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img2_Sharpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img1_Original);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LAM SAC NET ANH MAU";
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Sharpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img1_Original;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img2_Sharpen;
    }
}

