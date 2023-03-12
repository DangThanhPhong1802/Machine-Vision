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
using ZedGraph;


namespace MP05_BieuDoHistogram_GrayScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load hình gốc và hiển thị lên pic1_Original
            Bitmap Original = new Bitmap(@"D:\Visual Studio 2022\Source\Nhom_07_BPT_C_Sharp\bird_small_resize.jpg");
            pic1_Original.Image = Original;
            //Tính Histogram
            double[,] Histo_Ori = Histogram_Original(Original);
            //Chuyển đổi kiểu DL
            List<PointPairList> points_1 = Convert_Histogram_Original(Histo_Ori);
            //Vẽ biểu đồ Histogram và cho hiển thị
            ZedGraph1_Original.GraphPane = BieuDoHis_Original(points_1);
            ZedGraph1_Original.Refresh();



            //Hiển thị hình mức xám lên pic2_Luminance
            Bitmap GrayScale_2 = LuminanceIMG(Original);
            pic2_Luminance.Image = GrayScale_2;
            //Tính Histogram
            double[] Histo_Gray = Histogram_GrayScale(GrayScale_2);
            //Chuyển đổi kiểu DL
            PointPairList points_2 = Convert_Histogram_GrayScale(Histo_Gray);
            //Vẽ biểu đồ Histogram và cho hiển thị
            ZedGraph2_Luminance.GraphPane = BieuDoHis_GrayScale(points_2);
            ZedGraph2_Luminance.Refresh();
            

        }

//########################################################################################################################//
//########################################################################################################################//

        public Bitmap LuminanceIMG(Bitmap Original)
        {
            Bitmap GrayScale_1 = new Bitmap(Original.Width, Original.Height);
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy điểm ảnh tại (x,y)
                    Color pixel = Original.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Giá trị mức xám điểm ảnh tại (x,y)
                    byte Gray_1 = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    //Gán gray vào hình mức xám
                    GrayScale_1.SetPixel(x, y, Color.FromArgb(Gray_1, Gray_1, Gray_1));

                }
            return GrayScale_1;
        }

//########################################################################################################################//
//########################################################################################################################//

        public double[,] Histogram_Original(Bitmap BMP)
        {
            //Dùng mảng 2 chiều để chứa thông tin Histogram với : 3 = số kênh màu RGB , 256 = 256 vị trí tương ứng từ 0-255
            double[,] Histo_Ori = new double[3,256];

            for (int x = 0; x < BMP.Width; x++)
                for (int y = 0; y < BMP.Height; y++)
                {
                    Color color = BMP.GetPixel(x, y);

                    byte RED = color.R;
                    byte GREEN = color.G;
                    byte BLUE = color.B;

                    Histo_Ori[0, RED]++;    //Histogram kênh màu RED
                    Histo_Ori[1, GREEN]++;  //Histogram kênh màu GREEN
                    Histo_Ori[2, BLUE]++;   //Histogram kênh màu BLUE

                }
            return Histo_Ori;  //Trả về mảng 2 chiều chứa thông tin Histogram của RGB
        }


        List<PointPairList> Convert_Histogram_Original(double[,] Histo_Ori)
        {
            //Dùng 1 mảng không cần khai báo trước số lượng phần tử để chứa các chuyển đổi
            List<PointPairList> points_1 = new List<PointPairList>();
            PointPairList REDPoints = new PointPairList();      //Chuyển đổi Histogram kênh RED
            PointPairList GREENPoints = new PointPairList();      //Chuyển đổi Histogram kênh GREEN
            PointPairList BLUEPoints = new PointPairList();      //Chuyển đổi Histogram kênh BLUE

            for (int i = 0; i < 256; i++)
            {
                //i là trục ngang : 0-255
                //Histo[i] là trục đứng : là số pixels cùng mức xám
                REDPoints.Add(i, Histo_Ori[0, i]);    //Chuyển đổi cho kênh RED
                GREENPoints.Add(i, Histo_Ori[1, i]);    //Chuyển đổi cho kênh GREEN
                BLUEPoints.Add(i, Histo_Ori[2, i]);    //Chuyển đổi cho kênh BLUE
            }
            //Add các kênh vào mảng points để trả về cho hàm
            points_1.Add(REDPoints);
            points_1.Add(BLUEPoints);
            points_1.Add(GREENPoints);

            return points_1;
        }

        public GraphPane BieuDoHis_Original(List<PointPairList> Histo_Ori)
        {
            //GraphPane là đối tượng biểu đồ của ZedGraph
            GraphPane gp1 = new GraphPane();

            //Tên biểu đồ
            gp1.Title.Text = @"Histogram - Original Image";

            //Khung chứa biểu đồ
            gp1.Rect = new Rectangle(0, 0, 500, 305);

            //Trục ngang
            gp1.XAxis.Title.Text = @"GT màu của điểm ảnh";
            gp1.XAxis.Scale.Min = 0;
            gp1.XAxis.Scale.Max = 255;
            gp1.XAxis.Scale.MajorStep = 5;   //Mỗi bước là 5
            gp1.XAxis.Scale.MinorStep = 1;   //mỗi bước trong 1 bước là 1

            //Trục đứng
            gp1.YAxis.Title.Text = @"Số pixel có cùng GT màu";
            gp1.YAxis.Scale.Min = 0;
            gp1.YAxis.Scale.Max = 15000;   //số này phải > kích thước ảnh (w x h)
            gp1.YAxis.Scale.MajorStep = 5;
            gp1.YAxis.Scale.MinorStep = 1;

            //Dùng biểu đồ dạng Bar để biểu diễn cho Histogram
            gp1.AddBar("Histogram's RED", Histo_Ori[0], Color.Red);
            gp1.AddBar("Histogram's GREEN", Histo_Ori[1], Color.Green);
            gp1.AddBar("Histogram's BLUE", Histo_Ori[2], Color.Blue);

            return gp1;

        }

        //########################################################################################################################//
        //########################################################################################################################//

        public double[] Histogram_GrayScale(Bitmap GrayScale_2)
        {
            //Mỗi pixel ảnh mức xám có giá trị từ 0-255 nên ta khai báo 1 mảng có 256 phần tử 
            //dùng để chứa số đếm các pixel có cùng mức xám trong ảnh
            //Nên dùng kiểu Double vì tổng số đếm có thể rất lớn, phụ thuộc vào kích thước ảnh
            double[] Histo_Gray = new double[256];

            for(int x=0; x< GrayScale_2.Width; x++)
                for(int y=0; y< GrayScale_2.Height; y++)
                {
                    Color color = GrayScale_2.GetPixel(x, y);

                    //Trong hình mức xám, giá trị kênh R cũng như G hoặc B
                    byte Gray_2 = color.R;

                    //Giá trị Gray_2 tính ra cũng chính là phần tử thứ Gray trong mảng Histogram đã khai báo
                    //và sẽ tăng số đếm của phần tử thứ Gray lên 1
                    Histo_Gray[Gray_2]++;

                }
            return Histo_Gray;
        }

        PointPairList Convert_Histogram_GrayScale(double[] Histo_Gray)
        {
            //PointPairList là kiểu DL của ZedGraph để vẽ biểu đồ
            PointPairList points_2 = new PointPairList();
            for(int i=0; i<Histo_Gray.Length; i++)
            {
                //i là trục ngang : 0-255
                //Histo[i] là trục đứng : là số pixels cùng mức xám
                points_2.Add(i, Histo_Gray[i]);
            }
            return points_2;
        }

        public GraphPane BieuDoHis_GrayScale(PointPairList Histo_Gray)
        {
            //GraphPane là đối tượng biểu đồ của ZedGraph
            GraphPane gp2 = new GraphPane();

            //Tên biểu đồ
            gp2.Title.Text = @"Histogram - Luminance Image";

            //Khung chứa biểu đồ
            gp2.Rect = new Rectangle(0, 0, 500, 305);

            //Trục ngang
            gp2.XAxis.Title.Text = @"GT mức xám của điểm ảnh";
            gp2.XAxis.Scale.Min = 0;
            gp2.XAxis.Scale.Max = 255;
            gp2.XAxis.Scale.MajorStep = 5;   //Mỗi bước là 5
            gp2.XAxis.Scale.MinorStep = 1;   //mỗi bước trong 1 bước là 1

            //Trục đứng
            gp2.YAxis.Title.Text = @"Số pixel cùng mức xám";
            gp2.YAxis.Scale.Min = 0;
            gp2.YAxis.Scale.Max = 15000;   //số này phải > kích thước ảnh (w x h)
            gp2.YAxis.Scale.MajorStep = 5;
            gp2.YAxis.Scale.MinorStep = 1;

            //Dùng biểu đồ dạng Bar để biểu diễn cho Histogram
            gp2.AddBar("Histogram", Histo_Gray, Color.OrangeRed);

            return gp2;
             
        }
        


    }
}
