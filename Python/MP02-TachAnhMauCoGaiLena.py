import cv2           #Thư viện xử lý ảnh
import numpy as np   #Thư viện Toán học

#Lấy và đọc ảnh gốc
img = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)

#Lấy kích thước ảnh
Height = len(img[0])
Width = len(img[1])

#Khai báo 3 biến chứa hình ở 3 kênh R-G-B
Red = np.zeros((Width, Height,3), np.uint8)    #Số 3 là 3 kênh, mỗi kênh 8-bit
Green = np.zeros((Width, Height,3), np.uint8)
Blue = np.zeros((Width, Height,3), np.uint8)

#Ban đầu set-zero cho tất cả điểm ảnh có trong cả 3 kênh trong mỗi hình
Red[:] = [0, 0, 0]
Green[:] = [0, 0, 0]
Blue[:] = [0, 0, 0]

#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (Width) :
    for y in range (Height) :

        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        #Mỗi pixel chứa 4 thông tin : R, G, B và độ trong suốt A
        R = img[x, y, 2]
        G = img[x, y, 1]
        B = img[x, y, 0]

        #Thiết lập màu cho 3 kênh
        Red[x, y, 2] = R
        Green[x, y, 1] = G
        Blue[x, y, 0] = B

#Hiển thị ảnh
cv2.imshow('Hinh Goc', img)
cv2.imshow('Kenh RED', Red)
cv2.imshow('Kenh GREEN', Green)
cv2.imshow('Kenh BLUE', Blue)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey(0)

#Giải phóng bộ nhớ
cv2.destroyAllWindows()