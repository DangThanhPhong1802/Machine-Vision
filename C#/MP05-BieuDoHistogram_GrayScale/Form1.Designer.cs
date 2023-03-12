namespace MP05_BieuDoHistogram_GrayScale
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pic1_Original = new System.Windows.Forms.PictureBox();
            this.ZedGraph1_Original = new ZedGraph.ZedGraphControl();
            this.pic2_Luminance = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZedGraph2_Luminance = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đặng Thanh Phong - 20146132";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Original Image";
            // 
            // pic1_Original
            // 
            this.pic1_Original.Location = new System.Drawing.Point(22, 66);
            this.pic1_Original.Name = "pic1_Original";
            this.pic1_Original.Size = new System.Drawing.Size(400, 305);
            this.pic1_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1_Original.TabIndex = 2;
            this.pic1_Original.TabStop = false;
            // 
            // ZedGraph1_Original
            // 
            this.ZedGraph1_Original.Location = new System.Drawing.Point(447, 66);
            this.ZedGraph1_Original.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZedGraph1_Original.Name = "ZedGraph1_Original";
            this.ZedGraph1_Original.ScrollGrace = 0D;
            this.ZedGraph1_Original.ScrollMaxX = 0D;
            this.ZedGraph1_Original.ScrollMaxY = 0D;
            this.ZedGraph1_Original.ScrollMaxY2 = 0D;
            this.ZedGraph1_Original.ScrollMinX = 0D;
            this.ZedGraph1_Original.ScrollMinY = 0D;
            this.ZedGraph1_Original.ScrollMinY2 = 0D;
            this.ZedGraph1_Original.Size = new System.Drawing.Size(500, 305);
            this.ZedGraph1_Original.TabIndex = 3;
            // 
            // pic2_Luminance
            // 
            this.pic2_Luminance.Location = new System.Drawing.Point(22, 417);
            this.pic2_Luminance.Name = "pic2_Luminance";
            this.pic2_Luminance.Size = new System.Drawing.Size(400, 305);
            this.pic2_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2_Luminance.TabIndex = 5;
            this.pic2_Luminance.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Luminance Image";
            // 
            // ZedGraph2_Luminance
            // 
            this.ZedGraph2_Luminance.Location = new System.Drawing.Point(447, 417);
            this.ZedGraph2_Luminance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZedGraph2_Luminance.Name = "ZedGraph2_Luminance";
            this.ZedGraph2_Luminance.ScrollGrace = 0D;
            this.ZedGraph2_Luminance.ScrollMaxX = 0D;
            this.ZedGraph2_Luminance.ScrollMaxY = 0D;
            this.ZedGraph2_Luminance.ScrollMaxY2 = 0D;
            this.ZedGraph2_Luminance.ScrollMinX = 0D;
            this.ZedGraph2_Luminance.ScrollMinY = 0D;
            this.ZedGraph2_Luminance.ScrollMinY2 = 0D;
            this.ZedGraph2_Luminance.Size = new System.Drawing.Size(500, 305);
            this.ZedGraph2_Luminance.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.ZedGraph2_Luminance);
            this.Controls.Add(this.pic2_Luminance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ZedGraph1_Original);
            this.Controls.Add(this.pic1_Original);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img1_Luminance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic1_Original;
        private ZedGraph.ZedGraphControl ZedGraph1_Original;
        private System.Windows.Forms.PictureBox pic2_Luminance;
        private System.Windows.Forms.Label label5;
        private ZedGraph.ZedGraphControl ZedGraph2_Luminance;
    }
}

