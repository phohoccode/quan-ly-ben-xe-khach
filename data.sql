-- Bảng công việc
INSERT INTO CONGVIEC (TenCongViec) VALUES 
(N'Lái xe'),
(N'Phụ xe'),
(N'Quản lý bến'),
(N'Nhân viên bán vé'),
(N'Nhân viên vệ sinh'),
(N'Quản trị hệ thống'),
(N'Tài xế'),
(N'Tiếp viên'),
(N'Nhân viên bảo vệ'),
(N'Nhân viên kiểm tra vé');
go

-- Bảng quyền hạn
INSERT INTO QUYENHAN (LoaiQuyenHan, MoTa) VALUES
(0, N'Khách hàng'),
(1, N'Nhân viên'),
(2, N'Admin');
go


-- Bảng nhân viên
INSERT INTO NHANVIEN (Email, MatKhau, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaCongViec, MaQuyenHan) VALUES
('nhanvien1@benxe.com', 'matkhau1', N'Nguyễn Văn A', '1990-01-01', 1, N'Hà Nội', '0123456789', 1, 1),
('nhanvien2@benxe.com', 'matkhau2', N'Nguyễn Thị B', '1992-02-02', 0, N'Đà Nẵng', '0987654321', 2, 1),
('nhanvien3@benxe.com', 'matkhau3', N'Phạm Văn C', '1993-03-03', 1, N'Hồ Chí Minh', '0912345678', 3, 1),
('nhanvien4@benxe.com', 'matkhau4', N'Trần Thị D', '1994-04-04', 0, N'Hải Phòng', '0923456789', 4, 1),
('nhanvien5@benxe.com', 'matkhau5', N'Lê Văn E', '1995-05-05', 1, N'Cần Thơ', '0934567890', 5, 1),
('nhanvien6@benxe.com', 'matkhau6', N'Nguyễn Văn F', '1996-06-06', 1, N'Quảng Ninh', '0945678901', 6, 1),
('nhanvien7@benxe.com', 'matkhau7', N'Trần Văn G', '1997-07-07', 1, N'Lâm Đồng', '0956789012', 7, 1),
('nhanvien8@benxe.com', 'matkhau8', N'Lê Thị H', '1998-08-08', 0, N'Nam Định', '0967890123', 8, 1),
('nhanvien9@benxe.com', 'matkhau9', N'Phan Văn I', '1999-09-09', 1, N'Bắc Ninh', '0978901234', 9, 1),
('admin@benxe.com', 'admin123', N'Ngô Văn K', '1980-10-10', 1, N'Thanh Hóa', '0989012345', 10, 2);
go


-- Bảng khách hàng
INSERT INTO KHACHHANG (Email, MatKhau, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaQuyenHan) VALUES
('khachhang1@gmail.com', '123456', N'Nguyễn Văn A', '1985-01-01', 1, N'Hà Nội', '0123456789', 1),
('khachhang2@gmail.com', '123456', N'Trần Thị B', '1990-02-02', 0, N'Hải Phòng', '0987654321', 1),
('khachhang3@gmail.com', '123456', N'Lê Văn C', '1992-03-03', 1, N'Đà Nẵng', '0912345678', 1),
('khachhang4@gmail.com', '123456', N'Phạm Thị D', '1994-04-04', 0, N'Hồ Chí Minh', '0923456789', 1),
('khachhang5@gmail.com', '123456', N'Nguyễn Văn E', '1996-05-05', 1, N'Cần Thơ', '0934567890', 1),
('khachhang6@gmail.com', '123456', N'Trần Văn F', '1998-06-06', 1, N'Quảng Ninh', '0945678901', 1),
('khachhang7@gmail.com', '123456', N'Lê Thị G', '2000-07-07', 0, N'Lâm Đồng', '0956789012', 1),
('khachhang8@gmail.com', '123456', N'Phan Văn H', '1987-08-08', 1, N'Nam Định', '0967890123', 1),
('khachhang9@gmail.com', '123456', N'Ngô Thị I', '1999-09-09', 0, N'Bắc Ninh', '0978901234', 1),
('khachhang10@gmail.com', '123456', N'Nguyễn Văn K', '1995-10-10', 1, N'Thanh Hóa', '0989012345', 1);
go


-- Bảng xe khách
INSERT INTO XEKHACH (TenNhaXe, SoChoNgoi, BienSo, LoaiXe, TrangThai) VALUES
(N'Nhà xe A', 45, '30A-12345', N'Xe giường nằm', 0),
(N'Nhà xe B', 30, '31B-23456', N'Xe ghế ngồi', 0),
(N'Nhà xe C', 50, '32C-34567', N'Xe giường nằm', 0),
(N'Nhà xe D', 35, '33D-45678', N'Xe ghế ngồi', 0),
(N'Nhà xe E', 40, '34E-56789', N'Xe giường nằm', 0),
(N'Nhà xe F', 45, '35F-67890', N'Xe giường nằm', 1),
(N'Nhà xe G', 20, '36G-78901', N'Xe mini', 0),
(N'Nhà xe H', 50, '37H-89012', N'Xe giường nằm', 1),
(N'Nhà xe I', 60, '38I-90123', N'Xe giường nằm', 2),
(N'Nhà xe J', 55, '39J-01234', N'Xe ghế ngồi', 0);
go

-- Bảng loại vé
INSERT INTO LOAIVE (TenLoaiVe, GiaVe) VALUES
(N'Vé thường', 100000),
(N'Ve VIP', 150000),
(N'Ve khuyến mãi', 80000),
(N'Vé ghế ngồi', 90000),
(N'Ve giường nằm', 120000),
(N'Vé ngày lễ', 200000),
(N'Vé trẻ em', 50000),
(N'Vé sinh viên', 70000),
(N'Ve khứ hồi', 180000),
(N'Ve một chiều', 100000);
go

-- Bảng vé xe
INSERT INTO LICHSUDATVE (MaKhachHang, MaXe, MaLoaiVe, TrangThaiVe) VALUES
(1, 1, 1, 0),
(2, 2, 2, 0),
(3, 3, 3, 0),
(4, 4, 4, 0),
(5, 5, 5, 0),
(6, 6, 6, 1),
(7, 7, 7, 0),
(8, 8, 8, 1),
(9, 9, 9, 0),
(10, 10, 10, 0);
go

-- Bảng lịch trình
INSERT INTO LICHTRINH (MaXe, TuyenDuong, DiemXuatPhat, DiemDen, NgayKhoiHanh, GioKhoiHanh) VALUES
(1, N'Hà Nội - Hải Phòng', N'Hà Nội', N'Hải Phòng', '2024-12-01', '07:00'),
(2, N'Đà Nẵng - Huế', N'Đà Nẵng', N'Huế', '2024-12-02', '08:00'),
(3, N'Hồ Chí Minh - Cần Thơ', N'Hồ Chí Minh', N'Cần Thơ', '2024-12-03', '09:00'),
(4, N'Hải Phòng - Quảng Ninh', N'Hải Phòng', N'Quảng Ninh', '2024-12-04', '10:00'),
(5, N'Đà Nẵng - Quảng Ngãi', N'Đà Nẵng', N'Quảng Ngãi', '2024-12-05', '11:00'),
(6, N'Hà Nội - Thanh Hóa', N'Hà Nội', N'Thanh Hóa', '2024-12-06', '06:00'),
(7, N'Cần Thơ - Sóc Trăng', N'Cần Thơ', N'Sóc Trăng', '2024-12-07', '12:00'),
(8, N'Nam Định - Hà Nam', N'Nam Định', N'Hà Nam', '2024-12-08', '13:00'),
(9, N'Bắc Ninh - Hải Dương', N'Bắc Ninh', N'Hải Dương', '2024-12-09', '14:00'),
(10, N'Thái Bình - Quảng Ninh', N'Thái Bình', N'Quảng Ninh', '2024-12-10', '15:00');
go


-- Bảng khiếu nại
INSERT INTO KHIEUNAI (MaKhachHang, LyDoKhieuNai, MoTa, TrangThai) VALUES
(1, N'Chất lượng dịch vụ kém', N'Dịch vụ không như mong đợi, thời gian chờ xe lâu và thái độ phục vụ không tốt.', 0),
(2, N'Không hài lòng về chuyến đi', N'Xe chạy trễ giờ và không thông báo cho khách hàng.', 0),
(3, N'Vấn đề về xe', N'Xe không chạy ổn định, bị hư giữa chặng đường.', 1),
(4, N'Nhân viên không chuyên nghiệp', N'Nhân viên không hướng dẫn đúng, thái độ thiếu tôn trọng.', 0),
(5, N'Giá vé quá cao', N'Giá vé không hợp lý so với chất lượng dịch vụ cung cấp.', 1),
(6, N'Xe không đúng lịch trình', N'Xe không đúng giờ và không có thông báo, khách hàng bị ảnh hưởng lớn.', 0),
(7, N'Đặt vé bị lỗi hệ thống', N'Hệ thống không nhận đặt vé, mặc dù đã thanh toán thành công.', 1),
(8, N'Quá đông khách trên xe', N'Mặc dù có vé nhưng không còn chỗ ngồi, khách hàng phải đứng suốt hành trình.', 0),
(9, N'Không có chỗ đỗ xe', N'Khi đến điểm đỗ, không có chỗ đỗ, phải chờ đợi rất lâu.', 2),
(10, N'Thái độ của nhân viên không tốt', N'Nhân viên không giúp đỡ khi yêu cầu thông tin về chuyến đi.', 0)


