using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP06_KhongGianMauCMYK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Load hình gốc lên img1_Original
            Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color_resize.jpg");
            img1_Original.Image = Original;

            //Hiển thị các kênh màu CMYK được chuyển từ RGB
            List<Bitmap> CMYK = RGBtoCMYK(Original);
            img2_Cyan.Image = CMYK[0];
            img3_Magenta.Image = CMYK[1];
            img4_Yellow.Image = CMYK[2];
            img5_Black.Image = CMYK[3];

        }

        public List<Bitmap> RGBtoCMYK(Bitmap Original)
        {
            /*---------------------------------------------------------------------------
             Lưu ý : 
                Cyan (xanh dương) = Green và Blue => set kênh Red = 0
                Magenta (tím) = Red và Blue => set kênh Green = 0
                Yellow (vàng) = Red và Green => set kênh Blue = 0
             --------------------------------------------------------------------------*/

            //Tạo 1 list chứa 4 kênh ảnh tương ứng C-M-Y-K
            //Kiểu List là 1 mảng không bắt khai báo kích thước trước
            List<Bitmap> CMYK = new List<Bitmap>();

            /*Mỗi kênh trong Không Gian Màu CMYK được hiển thị bởi 1 hình Bitmap
                Lúc này, kích thước mỗi hình phải bằng kích thước hình gốc để sau tính toán chuyển đổi kênh màu được thực hiện đúng
                cho từng pixel */
            Bitmap Cyan = new Bitmap(Original.Width, Original.Height);
            Bitmap Magenta = new Bitmap(Original.Width, Original.Height);
            Bitmap Yellow = new Bitmap(Original.Width, Original.Height);
            Bitmap Black = new Bitmap(Original.Width, Original.Height);


            //Tiến hành quét ảnh gốc bằng 2 vòng For theo cột : từ cột này sang cột khác , từ trái qua phải
            for (int x=0; x<Original.Width; x++)
                for (int y=0; y<Original.Height;y++)
                {
                    //Lấy pixel tại điểm (x,y)
                    //Tại mỗi điểm pixel đang được quét ta tiến hành lấy thông tin tại điểm ảnh đó 
                    //Do là ảnh gốc RGB nên mỗi pixel sẽ chứa thông tin của 3 kênh tương ứng R-G-B
                    //Mỗi kênh là 8-bits = 1 byte nên dùng kiểu DL Byte để chứa thông tin kênh màu tương ứng
                    Color pixel = Original.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Set màu Cyan
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));
                    //Set màu Magenta
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));
                    //Set màu Yellow
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));
                    //Set màu Black
                    //Do hàm MIN có 2 đối số đầu vào nên thực hiện 2 lần
                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K,K,K));
                }
            /*Add các hình tương ứng vào kênh màu C-M-Y-K vào List
                Kiểu List là 1 mảng không bắt khai báo kích thước trước nên ta có thể Add các element của List vào 
                mà không cần quan tâm nó có bị tràn kích thước hay không*/
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);

            //Hàm trả về là 1 List 4 ảnh Bitmap tương ứng 4 kênh C-M-Y-K
            return CMYK;

        }
    }
}
