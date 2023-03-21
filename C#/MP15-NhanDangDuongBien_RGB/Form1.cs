using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP15_NhanDangDuongBien_RGB
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
                    int gxx=0, gyy=0, gxy=0, gxR=0, gxG=0, gxB=0, gyR=0, gyG=0, gyB=0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = Original.GetPixel(i, j);
                            int gR = color.R;
                            int gG = color.G;
                            int gB = color.B;

                            gxR += gR * MTSobelx[i - x + 1, j - y + 1];
                            gyR += gR * MTSobely[i - x + 1, j - y + 1];

                            gxG += gG * MTSobelx[i - x + 1, j - y + 1];
                            gyG += gG * MTSobely[i - x + 1, j - y + 1];

                            gxB += gB * MTSobelx[i - x + 1, j - y + 1];
                            gyB += gB * MTSobely[i - x + 1, j - y + 1];

                        }
                    //CT (6.7-5) đến (6.7-7) để tính các giá trị gxx, gyy và gxy
                    gxx = (Math.Abs(gxR) * Math.Abs(gxR)) + (Math.Abs(gxG) * Math.Abs(gxG)) + (Math.Abs(gxB) * Math.Abs(gxB));
                    gyy = (Math.Abs(gyR) * Math.Abs(gyR)) + (Math.Abs(gyG) * Math.Abs(gyG)) + (Math.Abs(gyB) * Math.Abs(gyB));
                    gxy = (gxR * gyR) + (gxG * gyG) + (gxB * gyB);

                    //CT (6.7-8) : tính góc theta : dùng hàm atan2 trong python trong TH mẫu số (gxx-gyy)=0
                    double theta = 0.5 * Math.Atan2((2 * gxy), (gxx - gyy));

                    //CT 6.7-9 để tính giá trị F0(x, y) : 
                    double F0 = Math.Sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)));

                    //So sánh GT ngưỡng
                    if (F0 <= Nguong)
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
            Bitmap AnhDuongBien = SobelIMG(Original, Nguong);
            img2_Sobel.Image = AnhDuongBien;
        }
    }
}
