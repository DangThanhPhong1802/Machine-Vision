using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP14_NhanDangDuongBien_GrayScale
{
    public partial class Form1 : Form
    {
        //Load hình gốc cô gái Lena
        Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color.jpg");

        public Form1()
        {
            InitializeComponent();

            //Hiển thị hình gốc lên im1_Original
            img1_Original.Image = Original;
        }

        public Bitmap LuminanceIMG(Bitmap Original)
        {
            Bitmap GrayScale = new Bitmap(Original.Width, Original.Height);
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy điểm ảnh tại (x,y)
                    Color pixel = Original.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Giá trị mức xám điểm ảnh tại (x,y)
                    byte Gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    //Gán gray vào hình mức xám
                    GrayScale.SetPixel(x, y, Color.FromArgb(Gray, Gray, Gray));

                }
            return GrayScale;
        }

        public Bitmap SobelIMG(Bitmap Hinhxam, int Nguong)
        {
            int[,] MTSobelx =
            {
                {-1, -2, -1},
                {0, 0, 0},
                {1, 2, 1 },
            };
            int[,] MTSobely =
            {
                {-1, 0, 1 },
                {-2, 0, 2 },
                {-1, 0, 1 },
            };
            Bitmap AnhDuongBien = new Bitmap(Hinhxam.Width, Hinhxam.Height);
            for (int x = 1; x < Hinhxam.Width - 1; x++)
                for (int y = 1; y < Hinhxam.Height - 1; y++)
                {
                    int gx = 0, gy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = Hinhxam.GetPixel(i, j);
                            int gR = color.R;
                            gx += gR * MTSobelx[i - x + 1, j - y + 1];
                            gy += gR * MTSobely[i - x + 1, j - y + 1];

                        }
                    int M = Math.Abs(gx) + Math.Abs(gy);
                    if (M < Nguong)
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return AnhDuongBien;
        }
        private void btn_RUN_Click(object sender, EventArgs e)
        {
            //Lấy GT ngưỡng từ thanh cuộn
            //Do value của thanh cuộn là kiểu int, trong khi ngưỡng là kiểu Byte
            //Do đó phải chuyển từ Int về Byte
            byte Nguong = (byte)scroll_Nguong.Value;

            //Hiển thị Gt ngưỡng
            lb_Nguong.Text = Nguong.ToString();
            Bitmap GrayScale = LuminanceIMG(Original);
            Bitmap AnhDuongBien = SobelIMG(GrayScale, Nguong);
            img2_Sobel.Image = AnhDuongBien;
        }
    }
}
