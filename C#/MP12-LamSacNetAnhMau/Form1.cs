using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP12_LamSacNetAnhMau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Load và hiển thị hình gốc cô gái Lena
            Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color.jpg");
            img1_Original.Image = Original;

            //Tạo biến chứa hình sắc nét sau đó cho hiển thị
            Bitmap SharpenIMG = Sharpen_3x3(Original);
            img2_Sharpen.Image = SharpenIMG;
        }

        public Bitmap Sharpen_3x3(Bitmap Original)
        {
            int[,] matrix = { {0,-1,0}, {-1,4,-1}, {0,-1,0} };

            //Tạo sẵn 1 hình Bitmap để chứa ảnh được làm mượt
            Bitmap SharpenIMG = new Bitmap(Original.Width, Original.Height);

            //Quét các điểm ảnh có trong hình gốc RGB
            //Để dễ lập trình, ta bỏ qua viền ngoài của ảnh
            //Với Mask 3x3 : chỉ tính từ x=1 tới x=width-1 ; y=1 tới y=height-1
            for (int x = 1; x < Original.Width - 1; x++)
                for (int y = 1; y < Original.Height - 1; y++)
                {
                    //Các biến này chứa các giá trị cộng dồn của điểm ảnh nằm trong mặt nạ
                    //Khai báo các biến sau kiểu int để có thể đọc được giá trị cộng dồn của các pixel
                    int Rs = 0, Gs = 0, Bs = 0;
                    int ShR = 0, ShG = 0, ShB = 0;

                    //Quét các điểm trong mặt nạ
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            //Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                            Color color = Original.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Nhân tích chập tất cả các điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                            Rs += R * matrix[i - x + 1, j - y + 1];
                            Gs += G * matrix[i - x + 1, j - y + 1];
                            Bs += B * matrix[i - x + 1, j - y + 1];
                        }
                    //Kết thúc quét và cộng dồn
                    //Tính điểm làm sắc nét mỗi kênh theo CT 3.6-7 ứng với từng kênh R-G-B
                    Color color1 = Original.GetPixel(x, y);
                    int R1 = color1.R;
                    int G1 = color1.G;
                    int B1 = color1.B;

                    ShR = R1 + Rs;
                    ShG = G1 + Gs;
                    ShB = B1 + Bs;

                    if (ShR < 0)
                        ShR = 0;
                    else if (ShR > 255)
                        ShR = 255;

                    if (ShG < 0)
                        ShG = 0;
                    else if (ShG > 255)
                        ShG = 255;

                    if (ShB < 0)
                        ShB = 0;
                    else if (ShB > 255)
                        ShB = 255;

                    //Set điểm ảnh đã làm mượt (mờ) vào ảnh Bitmap
                    SharpenIMG.SetPixel(x, y, Color.FromArgb(ShR,ShG,ShB));
                }
            return SharpenIMG;
        }
    }
}
