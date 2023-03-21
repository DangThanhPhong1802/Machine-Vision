using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP13_PhanDoanAnhMau
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

        private void btn_Run_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ các textbox và chuyển từ kiểu ký tự sang kiểu số
            int Threshold = Convert.ToInt16(tbox1_Threshold.Text);
            int x1 = Convert.ToInt16(tbox2_x1.Text);
            int y1 = Convert.ToInt16(tbox3_y1.Text);
            int x2 = Convert.ToInt16(tbox4_x2.Text);
            int y2 = Convert.ToInt16(tbox5_y2.Text);

            double aR_TB = 0, aG_TB = 0, aB_TB = 0;

            //Tính vector màu TB
            for(int x=x1; x<=x2;x++)
                for(int y=y1;y<=y2;y++)
                {
                    Color pixel1 = Original.GetPixel(x, y);
                    aR_TB += pixel1.R;
                    aG_TB += pixel1.G;
                    aB_TB += pixel1.B;

                }
            //Tại mỗi kênh R-G-B tiến hành tính TB cộng tất cả các điểm ảnh (pixel) thuộc vùng ảnh đã chọn ở trên
            double Size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            aR_TB /= Size;
            aG_TB /= Size;
            aB_TB /= Size;

            //Phân đoạn ảnh
            //Tạo 1 ảnh bitmap chứa hình segmentation
            Bitmap SegmentationIMG = new Bitmap(Original.Width, Original.Height);
            //Vector z : điểm ảnh tại vị trí (x, y) đang muốn tính xem là điểm thuộc nền (background) hay thuộc đối tượng (object)
            for(int x=0;x<Original.Width;x++)
                for(int y=0;y<Original.Height;y++)
                {
                    Color pixel2 = Original.GetPixel(x, y);
                    double zR = pixel2.R;
                    double zG = pixel2.G;
                    double zB = pixel2.B;

                    //CT 6.7-1 : D(z,a) = SQRT[(zR - aR)^2 + (zG - aG)^2 + (zB - aB)^2]
                    double D = Math.Sqrt(Math.Pow(zR - aR_TB, 2) + Math.Pow(zG - aG_TB, 2) + Math.Pow(zB - aB_TB, 2));

                    //So sánh với GT ngưỡng (threshold) để xác định xem điểm z(x,y) đang xét là background hay object
                    if ((int)D <= Threshold)
                        SegmentationIMG.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        SegmentationIMG.SetPixel(x, y, Color.FromArgb((int)zR, (int)zG, (int)zB));

                }
            //Hiển thị ảnh đã phân đoạn
            img2_Segmentation.Image = SegmentationIMG;
        }
    }
}
