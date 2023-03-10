import cv2
from PIL import Image
import numpy as np
import math

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('lena_color_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang HSV
Hue = Image.new(img_PIL.mode, img_PIL.size)
Saturation = Image.new(img_PIL.mode, img_PIL.size)
Value = Image.new(img_PIL.mode, img_PIL.size)
HSV = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (Width) :
    for y in range (Height) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_PIL.getpixel((x,y))
        #====================================Tính góc Theta======================================#
        #Tử số
        t1 = ((R-G)+(R-B))/2
        #Mẫu số
        t2 = math.sqrt((R-G)*(R-G)+(R-B)*(G-B))
        #Theta (hiện tại đang có đơn vị trong Python là Radian)
        theta = math.acos(t1/t2)

        #====================================Tính giá trị HUE======================================#
        H = 0
        #TH1 : Nếu Blue <= Green thì Hue = theta
        if B <= G :
            H = theta
        #TH2 : Nếu Blue > Green thì tính như sau :
        else :
            H = 2*(math.pi)-theta
            H = (H*180)/(math.pi)

        #====================================Tính giá trị SATURATION======================================#
        S = 1 - 3*(min(R,G,B))/(R+G+B)

        #====================================Tính giá trị Value======================================#
        #Nhìn tương tự như RGB chuyển sang GrayScale
        V = max(R,G,B)


        #Hiển thị các kênh giá trị H-S-V
        #Do S nằm trong [0,1] thì phải chuyển thành [0,255] thì mới hiển thị được hình
        Hue.putpixel((x,y),(np.uint8(H),np.uint8(H),np.uint8(H)))
        Saturation.putpixel((x,y),(np.uint8(S*255),np.uint8(S*255),np.uint8(S*255)))
        Value.putpixel((x,y),(np.uint8(V),np.uint8(V),np.uint8(V)))

        #Hiển thị hình HSV tổng hợp
        HSV.putpixel((x,y),(np.uint8(V),np.uint8(S*255),np.uint8(H)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
HueIMG = np.array(Hue)
SaturationIMG = np.array(Saturation)
ValueIMG = np.array(Value)
HSVIMG = np.array(HSV)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('HUE Image', HueIMG)
cv2.imshow('SATURATION Image', SaturationIMG)
cv2.imshow('VALUE Image', ValueIMG)
cv2.imshow('HSV Image', HSVIMG)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()