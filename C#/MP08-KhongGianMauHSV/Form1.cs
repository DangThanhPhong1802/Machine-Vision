using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP08_KhongGianMauHSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Load và hiển thị hình gốc lên img1_RGB 
            Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color_resize.jpg");
            img1_RGB.Image = Original;

            List<Bitmap> HSI = Convert_HSV(Original);

            img2_HUE.Image = HSI[0];
            img3_SATURATION.Image = HSI[1];
            img4_VALUE.Image = HSI[2];
            img5_HSV.Image = HSI[3];

        }

        public List<Bitmap> Convert_HSV(Bitmap Original)
        {
            //Tạo mảng động LIST chứa các KQ sau khi chuyển đổi
            List<Bitmap> HSV = new List<Bitmap>();

            //Tạo 3 kênh màu chứa hình các kênh H-S-V
            Bitmap Hue = new Bitmap(Original.Width, Original.Height);
            Bitmap Saturation = new Bitmap(Original.Width, Original.Height);
            Bitmap Value = new Bitmap(Original.Width, Original.Height);

            //Tạo hình HSV = kết hợp 3 kênh H-S-V
            Bitmap HSV_IMG = new Bitmap(Original.Width, Original.Height);

            //Quét từng điểm ảnh có trong hình và quét cột theo cột
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy thông tin điểm ảnh tại vị trí (x,y)
                    Color pixel = Original.GetPixel(x, y);

                    //Ở các dạng trước ta dùng kiểu Byte cho R-G-B
                    //Tuy nhiên, do quá trình tính toán HSV thì KQ trả về là kiểu Double (số thực) nên ta dùng kiểu Double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    /*=====================================TÍNH GÓC THETA=====================================*/
                    //Tử số
                    double t1 = ((R - G) + (R - B)) / 2;
                    //Mẫu số
                    double t2 = Math.Pow((R - G) * (R - G) + (R - B) * (G - B), 0.5);
                    //Theta
                    //Lưu ý : theo công thức là Độ. Nhưng trong C#.NET là Radian
                    double theta = Math.Acos(t1 / t2);

                    /*=====================================TÍNH GIÁ TRỊ HUE=====================================*/
                    double H = 0;
                    //TH1 : Nếu Blue <= Green thì Hue = theta
                    if (B <= G)
                    {
                        H = theta;

                    }
                    //TH2 : Nếu Blue > Green thì Hue được tính như sau : 
                    else
                    {
                        H = 2 * Math.PI - theta;
                        //Đổi ra Độ
                        H = (H * 180) / Math.PI;

                    }

                    /*=====================================TÍNH GIÁ TRỊ SATURATION=====================================*/
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);

                    /*=====================================TÍNH GIÁ TRỊ VALUE=====================================*/
                    //Nhìn tương tự như RGB sang GrayScale
                    double V = Math.Max(R,Math.Max(G,B));




                    //Hiển thị các kênh giá trị H-S-V
                    //Lưu ý : phải ép kiểu của H-S-V về kiểu Byte thì Bitmap mới hiểu và hiện thị được
                    //Do gt tính của S nằm trong [0,1].
                    //Để Bitmap hiển thị được hình thì phải chuyển S sang gt [0,255] => S = S*255
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S * 255), (byte)(S * 255), (byte)(S * 255)));
                    Value.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));

                    //Hiển thị kênh giá trị tổng hợp HSI
                    HSV_IMG.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S * 255), (byte)V));

                }

            HSV.Add(Hue);
            HSV.Add(Saturation);
            HSV.Add(Value);
            HSV.Add(HSV_IMG);

            return HSV;

        }
    }
}
