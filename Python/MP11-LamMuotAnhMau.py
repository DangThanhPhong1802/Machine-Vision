import cv2
from PIL import Image
import numpy as np

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)
#img_OpenCV = cv2.imread('bird_small_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('lena_color_resize.jpg')
#img_PIL = Image.open('bird_small_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang YCrCb
Smooth_3x3 = Image.new(img_PIL.mode, img_PIL.size)
Smooth_5x5 = Image.new(img_PIL.mode, img_PIL.size)
Smooth_7x7 = Image.new(img_PIL.mode, img_PIL.size)
Smooth_9x9 = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#===================================================== 3x3 ==========================================================#
#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 3x3 : x=1 tới x=Width-1 ; y=1 tới y=Height-1
for x in range (1,Width-1) :
    for y in range (1,Height-1) :
        #Khai báo các biến này kiểu int để chứa và có thể đọc được giá trị cộng dồn nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
        #Quét các điểm trong mặt nạ
        #Lưu ý : Python (a,b) : Chạy từ a tới b-1. Muốn lấy bằng b thì giá trị đó phải +1
        for i in range(x-1,x+2) :
            for j in range(y-1,y+2) :
                #Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                R, G, B = img_PIL.getpixel((i,j))
                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
        #Kết thúc quét và cộng dồn
        #Tính trung bình cộng cho mỗi kênh theo CT 6.6-1 . Chính xác hơn là 6.6-2
        K = 3*3
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)
        #Set điểm ảnh làm mượt(mờ) vào ảnh
        Smooth_3x3.putpixel((x,y),(Bs,Gs,Rs))


#===================================================== 5x5 ==========================================================#
#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 5x5 : x=2 tới x=Width-2 ; y=2 tới y=Height-2
for x in range (2,Width-2) :
    for y in range (2,Height-2) :
        #Khai báo các biến này kiểu int để chứa và có thể đọc được giá trị cộng dồn nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
        #Quét các điểm trong mặt nạ
        #Lưu ý : Python (a,b) : Chạy từ a tới b-1. Muốn lấy bằng b thì giá trị đó phải +1
        for i in range(x-2,x+3) :
            for j in range(y-2,y+3) :
                #Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                R, G, B = img_PIL.getpixel((i,j))
                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
        #Kết thúc quét và cộng dồn
        #Tính trung bình cộng cho mỗi kênh theo CT 6.6-1 . Chính xác hơn là 6.6-2
        K = 5*5
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)
        #Set điểm ảnh làm mượt(mờ) vào ảnh
        Smooth_5x5.putpixel((x,y),(Bs,Gs,Rs))


#===================================================== 7x7 ==========================================================#
#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 7x7 : x=3 tới x=Width-3 ; y=3 tới y=Height-3
for x in range (3,Width-3) :
    for y in range (3,Height-3) :
        #Khai báo các biến này kiểu int để chứa và có thể đọc được giá trị cộng dồn nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
        #Quét các điểm trong mặt nạ
        #Lưu ý : Python (a,b) : Chạy từ a tới b-1. Muốn lấy bằng b thì giá trị đó phải +1
        for i in range(x-3,x+4) :
            for j in range(y-3,y+4) :
                #Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                R, G, B = img_PIL.getpixel((i,j))
                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
        #Kết thúc quét và cộng dồn
        #Tính trung bình cộng cho mỗi kênh theo CT 6.6-1 . Chính xác hơn là 6.6-2
        K = 7*7
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)
        #Set điểm ảnh làm mượt(mờ) vào ảnh
        Smooth_7x7.putpixel((x,y),(Bs,Gs,Rs))


#===================================================== 9x9 ==========================================================#
#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 9x9 : x=4 tới x=Width-4 ; y=4 tới y=Height-4
for x in range (4,Width-4) :
    for y in range (4,Height-4) :
        #Khai báo các biến này kiểu int để chứa và có thể đọc được giá trị cộng dồn nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
        #Quét các điểm trong mặt nạ
        #Lưu ý : Python (a,b) : Chạy từ a tới b-1. Muốn lấy bằng b thì giá trị đó phải +1
        for i in range(x-4,x+5) :
            for j in range(y-4,y+5) :
                #Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                R, G, B = img_PIL.getpixel((i,j))
                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
        #Kết thúc quét và cộng dồn
        #Tính trung bình cộng cho mỗi kênh theo CT 6.6-1 . Chính xác hơn là 6.6-2
        K = 9*9
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)
        #Set điểm ảnh làm mượt(mờ) vào ảnh
        Smooth_9x9.putpixel((x,y),(Bs,Gs,Rs))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Sm3x3 = np.array(Smooth_3x3)
Sm5x5 = np.array(Smooth_5x5)
Sm7x7 = np.array(Smooth_7x7)
Sm9x9 = np.array(Smooth_9x9)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('Smoothing - 3x3 Image', Sm3x3)
cv2.imshow('Smoothing - 5x5 Image', Sm5x5)
cv2.imshow('Smoothing - 7x7 Image', Sm7x7)
cv2.imshow('Smoothing - 9x9 Image', Sm9x9)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()