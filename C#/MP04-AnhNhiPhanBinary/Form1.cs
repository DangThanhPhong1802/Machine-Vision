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
using Emgu.Util;

namespace MP04_AnhNhiPhanBinary
{
    public partial class Form1 : Form
    {

        Bitmap Original;

        public Form1()
        {
            InitializeComponent();

            // Load hình gốc lên box img1_Original
            //Chuyển biến Original thành biến toàn cục (global) để sử dụng cho các hàm khác
            //Nên thay vì viết Bitmap Original ở đây thì ta đem lên hàng "18" như trên để dùng cho hàng "179"
            Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color_resize.jpg");
            img1_Original.Image = Original;

            //Hiển thị hình mức xám lên img2_Average
            img2_Average.Image = AverageIMG(Original);

            //Hiển thị hình mức xám lên img3_Lightness
            img3_Lightness.Image = LightnessIMG(Original);

            //Hiển thị hình mức xám lên img4_Luminance
            img4_Luminance.Image = LuminanceIMG(Original);

            //Hiển thị hình nhị phân lên img5_Binary - Giả sử ngưỡng ở đây ta đặt là 100
            img5_Binary.Image = BinaryIMG(Original, 100);

        }



        /// <summary>
        /// Phương pháp Average
        /// </summary>
        /// <param name="Original"></param>
        /// <returns></returns>
        public Bitmap AverageIMG(Bitmap Original)
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
                    // Do Gray được khai báo là kiểu Byte, nên phải ép công thức (R+G+B)/3 kiểu số thực về Byte
                    byte Gray = (byte)((R + G + B) / 3);

                    //Gán gray vào hình mức xám
                    GrayScale.SetPixel(x, y, Color.FromArgb(Gray, Gray, Gray));

                }
            return GrayScale;
        }


        /// <summary>
        /// Phương pháp Lightness
        /// </summary>
        /// <param name="Original"></param>
        /// <returns></returns>
        public Bitmap LightnessIMG(Bitmap Original)
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
                    // Do Gray được khai báo là kiểu Byte, nên phải ép công thức (Max+Min)/2 kiểu số thực về Byte
                    byte MAX = Math.Max(R, Math.Max(G, B));
                    byte MIN = Math.Min(R, Math.Min(G, B));
                    byte Gray = (byte)((MAX + MIN) / 2);


                    //Gán gray vào hình mức xám
                    GrayScale.SetPixel(x, y, Color.FromArgb(Gray, Gray, Gray));

                }
            return GrayScale;
        }


        /// <summary>
        /// Phương pháp Luminance
        /// </summary>
        /// <param name="Original"></param>
        /// <returns></returns>
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



        public Bitmap BinaryIMG(Bitmap Original, byte Nguong)
        {
            Bitmap Binary = new Bitmap(Original.Width, Original.Height);
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy điểm ảnh tại (x,y)
                    Color pixel = Original.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Giá trị mức xám điểm ảnh tại (x,y)
                    byte Bin = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    //Phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng
                    if (Bin < Nguong)
                        Bin = 0;
                    else
                        Bin = 255;

                    //Gán Bin vào hình nhị phân
                    Binary.SetPixel(x, y, Color.FromArgb(Bin, Bin, Bin));

                }
            return Binary;
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CrollNguongBinary_ValueChanged(object sender, EventArgs e)
        {
            //Lấy giá trị ngưỡng từ giá trị thanh cuộn CrollNguongBinary
            //Kiểu DL của Value thanh cuộn là int, còn giá tị ngưỡng là kiểu Byte nên phải ép int về Byte
            byte Threshold = (byte)CrollNguongBinary.Value;
            //Hiển thị giá trị ngưỡng lên NguongBin
            NguongBin.Text = Threshold.ToString();

            //Tính ảnh nhị phân và hiển thị
            img5_Binary.Image = BinaryIMG(Original, Threshold);

        }
    }
}
