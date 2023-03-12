import cv2                               #Thư viện XLA OpenCV
from PIL import Image                    #Thư viện XLA PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np                       #Thư viện toán học, đặc biệt là tính toán với ma trận
import matplotlib.pyplot as plt          #Thư viện vẽ biểu đồ

#============================================================================================================#
                                    #----------GRAYSCALE----------#
#============================================================================================================#
#Phương pháp Luminance
def LuminanceIMG(imgPIL) :
    #Tạo 1 ảnh có cùng size và mode với ảnh imgPIL
    #Ảnh này dùng để chứa KQ chuyển đổi RGB sang GrayScale
    Luminance = Image.new(imgPIL.mode, imgPIL.size)
    #Lấy kích thước của ảnh từ imgPIL
    Width_1 = Luminance.size[0]
    Height_1 = Luminance.size[1]
    # Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
    # Đọc giá trị pixel có trong hình
    for x in range(Width_1):
        for y in range(Height_1):
            # Lấy giá trị điểm ảnh tại vị trí (x,y)
            R, G, B = imgPIL.getpixel((x, y))
            # RGB -> GrayScale
            Gray_Luminance = np.uint8(0.2126 * R + 0.7152 * G + 0.0722 * B)
            # Gán giá trị Gray cho ảnh mức xám
            Luminance.putpixel((x, y), (Gray_Luminance, Gray_Luminance, Gray_Luminance))
    return Luminance
#============================================================================================================#
#Tính Histogram của ảnh xám
def Calculate_Histogram_Gray(GrayIMG) :
    #Mỗi pixel có giá trị từ 0-255 nên phải khai báo 1 mảng có 256 phần tử để chứa số đếm của các pixel có cùng giá trị
    Histo_Gray = np.zeros(256)
    #Kích thước ảnh
    Width_2 = GrayIMG.size[0]
    Height_2 = GrayIMG.size[1]

    for x in range(Width_2):
        for y in range(Height_2):
            #Lấy giá trị mức xám tại điểm (x,y)
            gR, gG, gB = GrayIMG.getpixel((x,y))
            #Giá trị Gray tính ra chính ra phần tử thứ Gray trong mảng Histo đã khai báo ở trên, sẽ tăng số đếm của phần tử Gray lên 1
            Histo_Gray[gR] += 1

    return Histo_Gray
#============================================================================================================#
#Vẽ biểu đồ Histogram GrayScale dùng thư viện Matplotlib
def Bieudo_Histogram_Gray(Histo_Gray) :
    Width_2 = 6
    Height_2 = 4
    plt.figure('Histogram - GrayScale', figsize=(((Width_2, Height_2))), dpi=100)
    Truc_X = np.zeros(256)
    Truc_X = np.linspace(0,256,256)
    plt.plot(Truc_X, Histo_Gray, color='Orange')
    plt.title('Biểu Đồ Histogram - GrayScale')
    plt.xlabel('GT mức xám')
    plt.ylabel('Số pixel cùng GT mức xám')
    plt.show()

#============================================================================================================#
                                    #----------RGB----------#
#============================================================================================================#
#Tính Histogram của ảnh RGB
#Khai báo mảng chứa 256 phần tử chứa điểm ảnh
def Calculate_Histogram_RGB(imgPIL) :
    Histo_R = np.zeros(256)
    Histo_G = np.zeros(256)
    Histo_B = np.zeros(256)

    #Kích thước ảnh
    Width_3 = imgPIL.size[0]
    Height_3 = imgPIL.size[1]

    for x in range(Width_3) :
        for y in range(Height_3) :
            #Lấy giá trị điểm ảnh tại vị trí (x,y)
            gR, gG, gB = imgPIL.getpixel((x, y))
            # Giá trị Gray tính ra chính ra phần tử thứ Gray trong mảng Histo đã khai báo ở trên, sẽ tăng số đếm của phần tử Gray lên 1
            Histo_R[gR] += 1
            Histo_G[gG] += 1
            Histo_B[gB] += 1
    return Histo_R, Histo_G, Histo_B
#============================================================================================================#
#Vẽ biểu đồ Histogram RGB dùng thư viện Matplotlib
def Bieudo_Histogram_RGB(Histo_R,Histo_G,Histo_B) :
    Width_3 = 6
    Height_3 = 4
    plt.figure('Histogram - RGB', figsize=(((Width_3, Height_3))), dpi=100)
    Truc_X = np.zeros(256)
    Truc_X = np.linspace(0,256,256)
    plt.plot(Truc_X, Histo_R, color='Red')
    plt.plot(Truc_X, Histo_G, color='Green')
    plt.plot(Truc_X, Histo_B, color='Blue')
    plt.title('Biểu Đồ Histogram - RGB')
    plt.xlabel('GT điểm ảnh')
    plt.ylabel('Số pixel cùng GT màu')
    plt.show()

#============================================================================================================#
#===========================================CHƯƠNG TRÌNH CHÍNH===============================================#
#Khai báo đường dẫn hình gốc
filehinh = r'bird_small.jpg'
#Đọc ảnh dùng thư viện OpenCV
imgOPENCV = cv2.imread(filehinh, cv2.IMREAD_COLOR)
#Đọc ảnh dùng thư viện PILLOW
imgPIL = Image.open(filehinh)


#Chuyển sang ảnh mức xám - Gray
GrayIMG = LuminanceIMG(imgPIL)
#Tính Histogram - Gray
Histo_Gray = Calculate_Histogram_Gray(GrayIMG)
#Chuyển ảnh PIl sang OpenCV để hiển thị bằng thư viện CV2 - Gray
GrayCV = np.array(GrayIMG)
cv2.imshow('GrayScale - Luminance', GrayCV)
#Hiển thị biểu đồ Histogram - Gray
Bieudo_Histogram_Gray(Histo_Gray)


#Tính Histogram - RGB
Histo_R, Histo_G, Histo_B = Calculate_Histogram_RGB(imgPIL)
#Chuyển ảnh PIl sang OpenCV để hiển thị bằng thư viện CV2 - RGB
cv2.imshow('RGB - Original',imgOPENCV)
#Hiển thị biểu đồ Histogram - RGB
Bieudo_Histogram_RGB(Histo_R, Histo_G, Histo_B)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()
#Giải phóng bộ nhớ
cv2.destroyAllWindows()

