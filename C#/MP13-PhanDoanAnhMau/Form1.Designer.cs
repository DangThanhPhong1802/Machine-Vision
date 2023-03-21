namespace MP13_PhanDoanAnhMau
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
            this.img2_Segmentation = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox1_Threshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox2_x1 = new System.Windows.Forms.TextBox();
            this.tbox3_y1 = new System.Windows.Forms.TextBox();
            this.tbox4_x2 = new System.Windows.Forms.TextBox();
            this.tbox5_y2 = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Segmentation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặng Thanh Phong - 20146132";
            // 
            // img1_Original
            // 
            this.img1_Original.Location = new System.Drawing.Point(49, 76);
            this.img1_Original.Name = "img1_Original";
            this.img1_Original.Size = new System.Drawing.Size(512, 512);
            this.img1_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_Original.TabIndex = 1;
            this.img1_Original.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color Segmentation";
            // 
            // img2_Segmentation
            // 
            this.img2_Segmentation.Location = new System.Drawing.Point(584, 76);
            this.img2_Segmentation.Name = "img2_Segmentation";
            this.img2_Segmentation.Size = new System.Drawing.Size(512, 512);
            this.img2_Segmentation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2_Segmentation.TabIndex = 3;
            this.img2_Segmentation.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1102, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Threshold :";
            // 
            // tbox1_Threshold
            // 
            this.tbox1_Threshold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox1_Threshold.Location = new System.Drawing.Point(1180, 130);
            this.tbox1_Threshold.Name = "tbox1_Threshold";
            this.tbox1_Threshold.Size = new System.Drawing.Size(130, 30);
            this.tbox1_Threshold.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1102, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn vùng ảnh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1128, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "x1 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1128, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "y1 =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1128, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "x2 =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1128, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "y2 =";
            // 
            // tbox2_x1
            // 
            this.tbox2_x1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox2_x1.Location = new System.Drawing.Point(1180, 207);
            this.tbox2_x1.Name = "tbox2_x1";
            this.tbox2_x1.Size = new System.Drawing.Size(130, 30);
            this.tbox2_x1.TabIndex = 12;
            // 
            // tbox3_y1
            // 
            this.tbox3_y1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox3_y1.Location = new System.Drawing.Point(1180, 246);
            this.tbox3_y1.Name = "tbox3_y1";
            this.tbox3_y1.Size = new System.Drawing.Size(130, 30);
            this.tbox3_y1.TabIndex = 13;
            // 
            // tbox4_x2
            // 
            this.tbox4_x2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox4_x2.Location = new System.Drawing.Point(1180, 286);
            this.tbox4_x2.Name = "tbox4_x2";
            this.tbox4_x2.Size = new System.Drawing.Size(130, 30);
            this.tbox4_x2.TabIndex = 14;
            // 
            // tbox5_y2
            // 
            this.tbox5_y2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox5_y2.Location = new System.Drawing.Point(1180, 326);
            this.tbox5_y2.Name = "tbox5_y2";
            this.tbox5_y2.Size = new System.Drawing.Size(130, 30);
            this.tbox5_y2.TabIndex = 15;
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(1156, 386);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(180, 110);
            this.btn_Run.TabIndex = 16;
            this.btn_Run.Text = "RUN Segmentation";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.tbox5_y2);
            this.Controls.Add(this.tbox4_x2);
            this.Controls.Add(this.tbox3_y1);
            this.Controls.Add(this.tbox2_x1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox1_Threshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img2_Segmentation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img1_Original);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PHAN DOAN ANH MAU - SEGMENTATION";
            ((System.ComponentModel.ISupportInitialize)(this.img1_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_Segmentation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img1_Original;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img2_Segmentation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox1_Threshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox2_x1;
        private System.Windows.Forms.TextBox tbox3_y1;
        private System.Windows.Forms.TextBox tbox4_x2;
        private System.Windows.Forms.TextBox tbox5_y2;
        private System.Windows.Forms.Button btn_Run;
    }
}

