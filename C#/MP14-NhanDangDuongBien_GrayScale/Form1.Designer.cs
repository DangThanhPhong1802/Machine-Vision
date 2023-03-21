namespace MP14_NhanDangDuongBien_GrayScale
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
            this.label3 = new System.Windows.Forms.Label();
            this.img2_Sobel = new System.Windows.Forms.PictureBox();
            this.scroll_Nguong = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Nguong = new System.Windows.Forms.Label();
            this.btn_RUN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Sobel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặng Thanh Phong - 20146132";
            // 
            // img1_Original
            // 
            this.img1_Original.Location = new System.Drawing.Point(50, 86);
            this.img1_Original.Name = "img1_Original";
            this.img1_Original.Size = new System.Drawing.Size(512, 512);
            this.img1_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_Original.TabIndex = 1;
            this.img1_Original.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edge Detection - Sobel - Luminance Image";
            // 
            // img2_Sobel
            // 
            this.img2_Sobel.Location = new System.Drawing.Point(603, 86);
            this.img2_Sobel.Name = "img2_Sobel";
            this.img2_Sobel.Size = new System.Drawing.Size(512, 512);
            this.img2_Sobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2_Sobel.TabIndex = 3;
            this.img2_Sobel.TabStop = false;
            // 
            // scroll_Nguong
            // 
            this.scroll_Nguong.Location = new System.Drawing.Point(50, 675);
            this.scroll_Nguong.Maximum = 255;
            this.scroll_Nguong.Name = "scroll_Nguong";
            this.scroll_Nguong.Size = new System.Drawing.Size(1065, 35);
            this.scroll_Nguong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Threshold : ";
            // 
            // lb_Nguong
            // 
            this.lb_Nguong.AutoSize = true;
            this.lb_Nguong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nguong.Location = new System.Drawing.Point(163, 639);
            this.lb_Nguong.Name = "lb_Nguong";
            this.lb_Nguong.Size = new System.Drawing.Size(0, 23);
            this.lb_Nguong.TabIndex = 8;
            // 
            // btn_RUN
            // 
            this.btn_RUN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RUN.Location = new System.Drawing.Point(493, 731);
            this.btn_RUN.Name = "btn_RUN";
            this.btn_RUN.Size = new System.Drawing.Size(174, 110);
            this.btn_RUN.TabIndex = 9;
            this.btn_RUN.Text = "Edge Detection";
            this.btn_RUN.UseVisualStyleBackColor = true;
            this.btn_RUN.Click += new System.EventHandler(this.btn_RUN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.btn_RUN);
            this.Controls.Add(this.lb_Nguong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scroll_Nguong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img2_Sobel);
            this.Controls.Add(this.img1_Original);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NHAN DANG DUONG BIEN - SOBEL - GRAYSCALE";
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Sobel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img1_Original;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img2_Sobel;
        private System.Windows.Forms.HScrollBar scroll_Nguong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Nguong;
        private System.Windows.Forms.Button btn_RUN;
    }
}

