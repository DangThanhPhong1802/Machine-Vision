import cv2                #Thư viện xử lý ảnh OpenCV
from PIL import Image     #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np        #Thư viện Toán học Numpy

#Đọc ảnh với OpenCV
img_1 = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_2 = Image.open('lena_color_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang GrayScale
img_3 = Image.new(img_2.mode, img_2.size)    #Average
img_4 = Image.new(img_2.mode, img_2.size)    #Lightness
img_5 = Image.new(img_2.mode, img_2.size)    #Luminance

#Lấy size ảnh từ img_PIL
Width_3 = img_3.size[0]
Height_3 = img_3.size[1]

Width_4 = img_4.size[0]
Height_4 = img_4.size[1]

Width_5 = img_5.size[0]
Height_5 = img_5.size[1]

#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (Width_3) :
    for y in range (Height_3) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_2.getpixel((x,y))
        #RGB -> GrayScale
        Gray_Average = np.uint8((R+G+B)/3)
        #Gán giá trị Gray cho ảnh mức xám
        img_3.putpixel((x,y),(Gray_Average, Gray_Average, Gray_Average))

for x in range (Width_4) :
    for y in range (Height_4) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_2.getpixel((x,y))
        #RGB -> GrayScale
        Gray_Lightness = np.uint8((min(R,G,B)+max(R,G,B))/2)
        #Gán giá trị Gray cho ảnh mức xám
        img_4.putpixel((x,y),(Gray_Lightness, Gray_Lightness, Gray_Lightness))

for x in range (Width_5) :
    for y in range (Height_5) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_2.getpixel((x,y))
        #RGB -> GrayScale
        Gray_Luminance = np.uint8(0.2126*R+0.7152*G+0.0722*B)
        #Gán giá trị Gray cho ảnh mức xám
        img_5.putpixel((x,y),(Gray_Luminance, Gray_Luminance, Gray_Luminance))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
GrayScale_1 = np.array(img_3)
GrayScale_2 = np.array(img_4)
GrayScale_3 = np.array(img_5)

#Hiển thị ảnh với OpenCV
cv2.imshow('Original Image', img_1)
cv2.imshow('Average Image', GrayScale_1)
cv2.imshow('Lightness Image', GrayScale_2)
cv2.imshow('Luminance Image', GrayScale_3)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey(0)

#Giải phóng bộ nhớ
cv2.destroyAllWindows()


