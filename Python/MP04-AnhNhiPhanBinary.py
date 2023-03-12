import cv2
from PIL import Image
import numpy as np

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('lena_color_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang Binary
img_Bin = Image.new(img_PIL.mode, img_PIL.size)

#Lấy size ảnh từ img_PIL
Width = img_Bin.size[0]
Height = img_Bin.size[1]

#Thiết lập giá trị ngưỡng để tính điểm nhị phân
Threshold = 130

for x in range (Width) :
    for y in range (Height) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_PIL.getpixel((x,y))
        #RGB -> GrayScale
        Gray_Average = np.uint8((R+G+B)/3)
        #Xác định giá trị điểm nhị phân
        if (Gray_Average < Threshold) :
            img_Bin.putpixel((x,y),(0,0,0))
        else :
            img_Bin.putpixel((x, y), (255,255,255))


#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
BinaryIMG = np.array(img_Bin)

#Hiển thị ảnh với OpenCV
cv2.imshow('Original Image', img_OpenCV)
cv2.imshow('Binary Image', BinaryIMG)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey(0)

#Giải phóng bộ nhớ
cv2.destroyAllWindows()


