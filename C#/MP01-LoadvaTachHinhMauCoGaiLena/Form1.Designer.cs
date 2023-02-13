namespace MP01_LoadvaTachHinhMauCoGaiLena
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
            this.components = new System.ComponentModel.Container();
            this.img1_HinhGoc = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.img2_RED = new Emgu.CV.UI.ImageBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img3_GREEN = new Emgu.CV.UI.ImageBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img4_BLUE = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.img1_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3_GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4_BLUE)).BeginInit();
            this.SuspendLayout();
            // 
            // img1_HinhGoc
            // 
            this.img1_HinhGoc.Location = new System.Drawing.Point(28, 72);
            this.img1_HinhGoc.Name = "img1_HinhGoc";
            this.img1_HinhGoc.Size = new System.Drawing.Size(300, 300);
            this.img1_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_HinhGoc.TabIndex = 2;
            this.img1_HinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đặng Thanh Phong - 20146132";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Original Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "RED Channel";
            // 
            // img2_RED
            // 
            this.img2_RED.Location = new System.Drawing.Point(453, 72);
            this.img2_RED.Name = "img2_RED";
            this.img2_RED.Size = new System.Drawing.Size(300, 300);
            this.img2_RED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2_RED.TabIndex = 5;
            this.img2_RED.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "GREEN Channel";
            // 
            // img3_GREEN
            // 
            this.img3_GREEN.Location = new System.Drawing.Point(28, 429);
            this.img3_GREEN.Name = "img3_GREEN";
            this.img3_GREEN.Size = new System.Drawing.Size(300, 300);
            this.img3_GREEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3_GREEN.TabIndex = 7;
            this.img3_GREEN.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "BLUE Channel";
            // 
            // img4_BLUE
            // 
            this.img4_BLUE.Location = new System.Drawing.Point(453, 429);
            this.img4_BLUE.Name = "img4_BLUE";
            this.img4_BLUE.Size = new System.Drawing.Size(300, 300);
            this.img4_BLUE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4_BLUE.TabIndex = 9;
            this.img4_BLUE.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img4_BLUE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img3_GREEN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img2_RED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img1_HinhGoc);
            this.Name = "Form1";
            this.Text = "MP01_Lena - 20146132 - DangThanhPhong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img1_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2_RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3_GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4_BLUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox img1_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox img2_RED;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox img3_GREEN;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox img4_BLUE;
    }
}

