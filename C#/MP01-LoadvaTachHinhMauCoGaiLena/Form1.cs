using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;


namespace MP01_LoadvaTachHinhMauCoGaiLena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Tạo biến chứa đường dẫn lưu trữ ảnh gốc
            string ViTri = @"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color_resize.jpg";

            //Tạo biến chứa hình Bitmap (hình gốc)
            Bitmap original = new Bitmap(ViTri);

            //Hiển thị hình gốc trong img1_HinhGoc
            img1_HinhGoc.Image = new Image<Bgr, byte> (original);

            //Khai báo 2 hình Bitmap để chứa 3 hình kênh R,G,B
            Bitmap RED = new Bitmap(original.Width, original.Height);
            Bitmap GREEN = new Bitmap(original.Width, original.Height);
            Bitmap BLUE = new Bitmap(original.Width, original.Height);

            //Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
            //Quét theo chiều ngang
            for (int x=0; x<original.Width; x++)
                //Quét theo chiều dọc
                for (int y=0; y<original.Height; y++)
                {
                    //Đọc giá trị pixel tại điểm ảnh có vị trí (x,y)
                    //Mỗi pixel chứa 4 thông tin : R, G, B và độ trong suốt A
                    Color pixel = original.GetPixel(x,y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A;

                    //Set giá trị pixel đọc được cho các hình chứa kênh màu tương ứng R,G,B
                    RED.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    GREEN.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    BLUE.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));
                }
            //Hiển thị 3 hình lên 3 kênh màu R,G,B
            img2_RED.Image = new Image<Bgr, byte> (RED);
            img3_GREEN.Image = new Image<Bgr, byte> (GREEN);
            img4_BLUE.Image = new Image<Bgr, byte> (BLUE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
