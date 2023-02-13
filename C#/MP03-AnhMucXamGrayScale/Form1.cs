using Emgu.CV.Structure;
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


namespace MP03_AnhMucXamGrayScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Load hình gốc lên box img1_OriginalIMG
            Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\lena_color_resize.jpg");
            img1_Original.Image = Original;

            //Hiển thị hình mức xám lên img2_AverageIMG
            img2_Average.Image = AverageIMG(Original);

            //Hiển thị hình mức xám lên img3_LightnessIMG
            img3_Lightness.Image = LightnessIMG(Original);

            //Hiển thị hình mức xám lên img4_LuminanceIMG
            img4_Luminance.Image = LuminanceIMG(Original);

        }



        
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
