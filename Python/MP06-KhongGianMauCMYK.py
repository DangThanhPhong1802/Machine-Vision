import cv2
from PIL import Image
import numpy as np

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('lena_color_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang CMYK
Cyan = Image.new(img_PIL.mode, img_PIL.size)
Magenta = Image.new(img_PIL.mode, img_PIL.size)
Yellow = Image.new(img_PIL.mode, img_PIL.size)
Black = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (Width) :
    for y in range (Height) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_PIL.getpixel((x,y))
        #Tiến hành trộn màu cho 4 kênh màu C-M-Y-K
            #Cyan (xanh dương) = Green và Blue => set kênh Red = 0
            #Magenta (tím) = Red và Blue => set kênh Green = 0
            #Yellow (vàng) = Red và Green => set kênh Blue = 0
        Cyan.putpixel((x,y),(B,G,0))
        Magenta.putpixel((x,y),(B,0,R))
        Yellow.putpixel((x,y),(0,G,R))
        #Do hàm Min có 2 đối số đầu vào nên phải thực hiện 2 lần
        Black.putpixel((x,y),(min(R,G,B),min(R,G,B),min(R,G,B)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
CyanIMG = np.array(Cyan)
MagentaIMG = np.array(Magenta)
YellowIMG = np.array(Yellow)
BlackIMG = np.array(Black)

#Hiển thị ảnh với OpenCV
cv2.imshow('Original Image', img_OpenCV)
cv2.imshow('Cyan Image', CyanIMG)
cv2.imshow('Magenta Image', MagentaIMG)
cv2.imshow('Yellow Image', YellowIMG)
cv2.imshow('Black Image', BlackIMG)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()

