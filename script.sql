CREATE DATABASE QUANLYBENXE
go

USE QUANLYBENXE
go

CREATE TABLE CONGVIEC(
	MaCongViec int identity primary key,
	TenCongViec nvarchar(50),
	NgayTao DATETIME DEFAULT GETDATE()
)
go


-- 0: KHÁCH HÀNG
-- 1: NHÂN VIÊN 
-- 2: ADMIN
CREATE TABLE QUYENHAN(
	MaQuyenHan int identity primary key,
	LoaiQuyenHan tinyint not null ,
	MoTa nvarchar(255) null,
	NgayTao DATETIME DEFAULT GETDATE()
)
go

CREATE TABLE NHANVIEN(
	MaNhanVien int identity primary key,
	Email varchar(100) unique not null,
	MatKhau varchar(50) not null,
	HoTen nvarchar(50) not null,
	NgaySinh date CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 18),
	GioiTinh tinyint default 0,
	DiaChi nvarchar(100) null,
	SoDienThoai char(10) null,
	MaCongViec int not null,
	MaQuyenHan int not null,
	NgayTao DATETIME DEFAULT GETDATE(),
	constraint fk_NHANVIEN_QUYENHAN foreign key(MaQuyenHan) references QUYENHAN(MaQuyenHan),
	constraint fk_NHANVIEN_CONGVIEC foreign key(MaCongViec) references CONGVIEC(MaCongViec)
)
go

CREATE TABLE KHACHHANG(
	MaKhachHang int identity primary key,
	Email varchar(100) unique not null,
	MatKhau varchar(50) not null,
	HoTen nvarchar(50) not null,
	NgaySinh date ,
	GioiTinh tinyint default 0,
	DiaChi nvarchar(100) null,
	SoDienThoai char(10) null,
	MaQuyenHan int default 0,
	NgayTao DATETIME DEFAULT GETDATE(),
	constraint fk_KHACHHANG_QUYENHAN foreign key(MaQuyenHan) references QUYENHAN(MaQuyenHan),
)
go

-- 0: Đổi mật khẩu
CREATE TABLE XACMINHTAIKHOAN (
    MaXacMinh INT IDENTITY PRIMARY KEY, 
    MaKhachHang INT NOT NULL,
    MaToken CHAR(6) NOT NULL,
    LoaiXacMinh TINYINT not null,
    NgayTao DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang) 
        ON DELETE CASCADE ON UPDATE CASCADE
);
go

-- 0: Hoạt động
-- 1: Ngừng hoạt động
-- 2: Bảo trì
CREATE TABLE XEKHACH (
    MaXe INT IDENTITY PRIMARY KEY,
    TenNhaXe NVARCHAR(100) NOT NULL,
    SoChoNgoi INT NOT NULL CHECK (SoChoNgoi > 0), 
    BienSo VARCHAR(20) UNIQUE NOT NULL,
    LoaiXe NVARCHAR(50) NOT NULL,
    TrangThai tinyint DEFAULT 0,
    NgayTao DATETIME DEFAULT GETDATE()
);
go

CREATE TABLE LOAIVE (
	MaLoaiVe INT IDENTITY PRIMARY KEY,
    TenLoaiVe NVARCHAR(50) not null, 
    GiaVe DECIMAL(10, 2) NOT NULL CHECK (GiaVe >= 0)
);
go

-- 0: Đã đặt
-- 1: Đã huỷ
CREATE TABLE VEXE (
    MaVe INT IDENTITY PRIMARY KEY,
    MaKhachHang INT NULL,
    MaXe INT NOT NULL,
    MaLoaiVe int not null, 
    NgayDatVe DATETIME DEFAULT GETDATE(),
    TrangThaiVe tinyint NOT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
        ON DELETE SET NULL,
    FOREIGN KEY (MaXe) REFERENCES XEKHACH(MaXe)
        ON DELETE CASCADE,
    FOREIGN KEY (MaLoaiVe) REFERENCES LOAIVE(MaLoaiVe) 
);
go

-- 0: Hoạt động
-- 1: Tạm hoãn
-- 2: Huỷ
CREATE TABLE LICHTRINH (
    MaLichTrinh INT IDENTITY PRIMARY KEY,
    MaXe INT,
    TuyenDuong NVARCHAR(255) NOT NULL,
	DiemXuatPhat NVARCHAR(255) NOT NULL,
    DiemDen NVARCHAR(255) NOT NULL,
    NgayKhoiHanh DATE NOT NULL,
    GioKhoiHanh TIME NOT NULL,
    TrangThai tinyint default 0,
    FOREIGN KEY (MaXe) REFERENCES XeKhach(MaXe)
        ON DELETE CASCADE
);
go

-- 0: Đang chờ xử lý
-- 1: Đã giải quyết
-- 2: Huỷ
CREATE TABLE KHIEUNAI (
    MaKhieuNai INT IDENTITY PRIMARY KEY,           
    MaKhachHang INT NOT NULL,                                    
    LyDoKhieuNai NVARCHAR(255) NOT NULL,                      
    MoTa NVARCHAR(MAX),                               
    NgayTao DATETIME DEFAULT GETDATE(),               
    TrangThai tinyint default 0,
    FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
        ON DELETE CASCADE ON UPDATE CASCADE           
);

