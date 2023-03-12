using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP09_KhongGianMauXYZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //Load và hiển thị hình gốc lên img1_RGB 
            Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color_resize.jpg");
            img1_RGB.Image = Original;

            List<Bitmap> XYZ = Convert_XYZ(Original);

            img2_X.Image = XYZ[0];
            img3_Y.Image = XYZ[1];
            img4_Z.Image = XYZ[2];
            img5_XYZ.Image = XYZ[3];
        }


        public List<Bitmap> Convert_XYZ(Bitmap Original)
        {
            //Tạo mảng động LIST chứa các KQ sau khi chuyển đổi
            List<Bitmap> XYZ = new List<Bitmap>();

            //Tạo 3 kênh màu chứa hình các kênh X-Y-Z
            Bitmap XIMG = new Bitmap(Original.Width, Original.Height);
            Bitmap YIMG = new Bitmap(Original.Width, Original.Height);
            Bitmap ZIMG = new Bitmap(Original.Width, Original.Height);

            //Tạo hình XYZ = kết hợp 3 kênh X-Y-Z
            Bitmap XYZ_IMG = new Bitmap(Original.Width, Original.Height);

            //Quét từng điểm ảnh có trong hình và quét cột theo cột
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy thông tin điểm ảnh tại vị trí (x,y)
                    Color pixel = Original.GetPixel(x, y);

                    //Ở các dạng trước ta dùng kiểu Byte cho R-G-B
                    //Tuy nhiên, do quá trình tính toán XYZ thì KQ trả về là kiểu Double (số thực) nên ta dùng kiểu Double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Tính X-Y-Z
                    double X = (0.4124564 * R + 0.3575761 * G + 0.1804375 * B);
                    double Y = (0.2126729 * R + 0.7151522 * G + 0.0721750 * B);
                    double Z = (0.0193339 * R + 0.1191920 * G + 0.9503041 * B);
                    

                    //Hiển thị các kênh giá trị X-Y-Z
                    //Lưu ý : phải ép kiểu của X-Y-Z về kiểu Byte thì Bitmap mới hiểu và hiện thị được
                    XIMG.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    YIMG.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    ZIMG.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));

                    //Hiển thị kênh giá trị tổng hợp XYZ
                    XYZ_IMG.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));

                }

            XYZ.Add(XIMG);
            XYZ.Add(YIMG);
            XYZ.Add(ZIMG);
            XYZ.Add(XYZ_IMG);

            return XYZ;

        }
    }
}
