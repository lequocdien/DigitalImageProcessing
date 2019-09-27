## Đồ án xử lý ảnh

## Mục lục

[I.Mở đầu](#modau)

[II.Image Enhancement](#imageenhacement)

=============================================

# I.Mở đầu

# II.Image Enhancement (Nâng cao hình ảnh)

## 1.Mục đích

- Nâng cao hình ảnh là xử lý làm cho hình ảnh hữu ích hơn
- Những lý do để thực hiện việc này là:
 	- Làm nổi bật lên nhiều chi tiết thú vị trong hình ảnh.
 	- Loại bỏ nhiễu (khử noise).
	- Làm cho hình ảnh trở nên hấp dẫn hơn.

## 2.Phân loại

- Có 2 loại kĩ thuật nâng cao hình ảnh:
 	- Kỹ thuật miền không gian: Thao tác trực tiếp với pixel hình ảnh.
  		- Cân bằng histogram ảnh: Cân bằng sáng lại ảnh.
  		- Kỹ thuật xử lý điểm: Tăng sáng, giảm sáng.
  		- Kỹ thuật xử lý láng giềng: Loại bỏ nhiễu.
 	- Kỹ thuật miền tần số: Thao tác biến đổi Fourier hoặc biến đổi wavelet của hình ảnh.
- Trong bài này chỉ quan tâm đến `kỹ thuật nâng cao ảnh trên miền không gian (không có quy luật)`.

## 3.Histogram equalisation

### 3.1.Khái niệm `Image Histogram`

`Image Histogram` cho ta thấy sự phân bố các mức độ màu xám trong hình ảnh.

### 3.2.Mục đích

Cân bằng sáng cho hình ảnh nghĩa là làm cho ảnh không quá tối cũng không quá sáng.

### 3.3.Giải thuật cân bằng Histogram

#TODO

### 3.4.Ứng dụng

Tăng độ tương phản cho ảnh.

## 4.Point processing

```	
		s = T(r) 
	   với: s là pixel đã được xử lý.
		r là pixel ảnh gốc.
```		

### 4 .1.Negative image

4.1.1.Mục đích

- Tăng cường chi tiết màu trắng hoặc màu xám trong vùng tối của hình ảnh.
- Chuyển ảnh tối sang ảnh sáng.

4.1.2.Giải thuật

```	
	s = 1.0 - r 
```

### 4.2.Thresholding

4.1.1.Mục đích

- Tách đối tượng quan tâm ra khỏi nền.

4.1.2.Giải thuật

```
	s = 1.0 khi r > thresholding
	    0.0 khi r <= thresholding 
```

### 4.3.Logarithmic

4.3.1.Mục đích

- Làm nổi bật lên nhiều chi tiết.
- Làm sáng hình ảnh.

4.3.2.Giải thuật

```	
	a = c * log(1 + r)
```

### 4.4.Power

4.4.1.Mục đích

- Làm tối hình ảnh.

4.4.2.Giải thuật

```
	s = c * r^y
```

### 4.5.Bit plane slicing

#TODO

## 5.Spatial Filtering

<img src="https://i.imgur.com/ILPX67j.png">

### 5.1.Min

- Lấy giá trị pixel thấp nhất trong vùng lân cận.

### 5.2.Max

- Lấy giá trị pixel cao nhất trong vùng lân cận.

### 5.3.Median

- Lấy giá trị midpoint sau khi đã sắp xếp và mảng 1 chiều.

- ex: [1,7,15,18,24,30,32,33,35] => Median là 15.

### 5.4.Averaging filter.

#### 5.4.1.Mục đích

- Làm min ảnh.
- Loại bỏ những chi tiết tốt.

#### 5.4.1.Bộ lọc

	| 1/9 | 1/9 | 1/9 |
	| 1/9 | 1/9 | 1/9 |
	| 1/9 | 1/9 | 1/9 |  

<img src="https://i.imgur.com/RImJxaJ.png">

### 5.5.Weighted averaging filter.

#### 5.4.1.Mục đích

- Làm min ảnh.
- Loại bỏ những chi tiết tốt.

#### 5.4.1.Bộ lọc

	| 1/16 | 2/16 | 1/16 |
	| 2/16 | 4/16 | 2/16 |
	| 1/16 | 2/16 | 1/16 |   

### 5.6.Laplac (Đạo hàm bậc 2 từ `Sharpening Filter`)

#### 5.6.1.Mục đích

- Phát hiện ra các cạnh của đối tượng.
- Làm nổi bật lên nhiều chi tiết tốt,			 phản ứng mạnh với các chi tiết tốt (vd: Đường mỏng) hơn so với `Sobel`.

#### 5.6.2.Bộ lọc

	| 0 | 1 | 0 |
	| 1 | -4 | 1 |
	| 0 | 1 | 0 |  

#### 5.6.3.Chú ý

- Bộ lọc Laplac không hề nâng cấp ảnh.
- Để nâng cấp ảnh cần lấy ảnh gốc - ảnh đã qua bộ lọc Laplac.
- Hoặc có thể dùng bộ lọc sau để `phát hiện ra cạnh của đối tượng` và `nâng cấp ảnh`.

	| 0 | -1 | 0 |
	| -1 | 5 | -1 |
	| 0 | -1 | 0 |

#### 5.6.4.Một số bộ lọc Laplac khác.

	| 1 | 1 | 1 |
	| 1 | -8 | 1 |
	| 1 | 1 | 1 |

	| -1 | -1 | -1 |
	| -1 | 9 | -1 |
	| -1 | -1 | -1 |

### 5.7.Sobel (Đạo hàm bậc 1 từ `Sharpening Filter`)

- Phát hiện ra các cạnh của đối tượng nhưng tạo ra đường viền giày hơn `Laplac`.
- Làm nổi bật lên nhiều chi tiết tốt.

#### 5.6.2.Bộ lọc

	| -1 | -2 | -1 |	| -1 | 0 | 1 |
	| 0 | 0 | 0 |		| -2 | 0 | 2 |
	| 1 | 2 | 1 |  		| -1 | 0 | 1 |

- Để thực hiện bộ lọc này, đưa hình ảnh qua từng bộ lọc sau đó cộng chúng lại với nhau.

### 5.8.Khắc phục mất đường biên.

- Tô thêm đường biên
- Nhân bản đường biên

## III.Image segmentation 

### 1.Mục đích

- Nhằm chia hình ảnh thành các vùng hoặc đối tượng có thể xử lý được. Nếu phân 
đoạn tốt các contours của objects sẽ xuất hiện và có thể trích ra để sử dụng.

### 2.Ứng dung

- Finding people, summarizing video, annotation figures, background subtraction,
finding buildings/river trong ảnh vệ tinh.

### 3.Point detection

### 4.Line detection

### 5.Edge detection

### 6.Thresholding

## IV.Image morphological







