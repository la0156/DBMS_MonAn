CREATE DATABASE DBMS_MONAN
GO

USE DBMS_MONAN
GO

CREATE TABLE TKhoan(
 TaiKhoan varchar(50) NOT NULL,
 MatKhau nvarchar(50) NULL,
 HoTen nvarchar(50) NULL,
 NamSinh date NULL,
 Email nvarchar(50) NULL,
 Quyen varchar(15) NULL,
 CONSTRAINT pk_TKhoan PRIMARY KEY(TaiKhoan)
)
GO

CREATE TABLE LoaiMonAn(
 IDLoaiMonAn int NOT NULL,
 TenLoaiMonAn nvarchar(50) NULL,
 CONSTRAINT pk_LoaiMonAn PRIMARY KEY(IDLoaiMonAn)
)	
GO

CREATE TABLE MonAn(
 IDMonAn int NOT NULL,
 IDLoaiMonAn int NOT NULL,
 TenMonAn nvarchar(50) NULL,
 XuatSu nvarchar(50) NULL,
 NgayNhap date NULL,
 Gia money NULL,
 CONSTRAINT pk_MonAn PRIMARY KEY(IDMonAn)
)
GO

CREATE TABLE NguyenLieu(
 IDNguyenLieu int NOT NULL,
 IDMonAn int NOT NULL,
 IDCongThuc int NOT NULL,
 TenMonAn nvarchar(50) NULL,
 NguyenLieuMon ntext NULL,
 ChuThich nvarchar(300) NULL,
 CONSTRAINT pk_NguyenLieu PRIMARY KEY(IDNguyenLieu)
)
GO

CREATE TABLE CongThuc(
 IDCongThuc int NOT NULL,
 NguyenLieu ntext NOT NULL,
 TenMonAn nvarchar(50) NULL,
 CachCheBien ntext NULL,
 MucDo nvarchar(50) NULL,
 ChuThich nvarchar(300) NULL,
 CONSTRAINT pk_CongThuc PRIMARY KEY(IDCongThuc)
)
GO

CREATE TABLE DiaDiem(
 TenMonAn nvarchar(50) NOT NULL,
 TenNhaHang nvarchar(300) NULL,
 DiaChi nvarchar(500) NULL,
 SDT int NULL,
 CONSTRAINT pk_DiaDiem PRIMARY KEY(TenMonAn)
)
GO

CREATE TABLE DanhGia(
 IDDanhGia int NOT NULL,
 IDMonAn int NOT NULL,
 IDKhachHang int NOT NULL,
 TenDanhGia nvarchar(50) NULL,
 TenMonAn nvarchar(50) NULL,
 Diem float NULL,
 ChuThich nvarchar(300) NULL,
 CONSTRAINT pk_DanhGia PRIMARY KEY(IDDanhGia)
)
GO


CREATE TABLE KhachHang(
 IDKhachHang int NOT NULL,
 TenKhachHang nvarchar(50) NULL,
 SDT int NULL,
 CMND int NULL,
 Email nvarchar(50) NULL,
 CONSTRAINT pk_KhachHang PRIMARY KEY(IDKhachHang)
)

CREATE TABLE DatMon(
 IDDatMon int NOT NULL,
 IDKhachHang int NOT NULL,
 IDNhanVien int NOT NULL,
 IDMonAn int NOT NULL,
 TenKhachHang nvarchar(50) NULL,
 NgayDat date NULL,
 SDT int NULL,
 TenMonAn nvarchar(50) NULL,
 CONSTRAINT pk_DatMon PRIMARY KEY(IDDatMon)
)

CREATE TABLE HoaDon(
 IDHoaDon int NOT NULL,
 IDDatMon int NOT NULL,
 TenKhachHang nvarchar(50) NULL,
 NgayDat date NULL,
 SDT int NULL,
 TenMonAn nvarchar(50) NULL,
 Gia money NULL,
 GiamGia money NULL,
 ThanhTien money NULL,
 CONSTRAINT pk_HoaDon PRIMARY KEY(IDHoaDon)
)

CREATE TABLE NhanVien(
 IDNhanVien int NOT NULL,
 TenNhanVien nvarchar(50) NULL,
 GioiTinh nvarchar(50) NULL,
 NamSinh date NULL,
 SDT int NULL,
 DiaChi nvarchar(500) NULL,
 CMND int NULL,
 Email nvarchar(50) NULL,
 CONSTRAINT pk_NhanVien PRIMARY KEY(IDNhanVien)
)



ALTER TABLE dbo.NguyenLieu ADD CONSTRAINT FK_NguyenLieu_CongThuc FOREIGN KEY(IDCongThuc) REFERENCES dbo.CongThuc(IDCongThuc)
ALTER TABLE dbo.NguyenLieu ADD CONSTRAINT FK_NguyenLieu_MonAn FOREIGN KEY(IDMonAn) REFERENCES dbo.MonAn(IDMonAn)
ALTER TABLE dbo.MonAn ADD CONSTRAINT FK_MonAn_DiaDiem FOREIGN KEY(TenMonAn) REFERENCES dbo.DiaDiem(TenMonAn)
ALTER TABLE dbo.MonAn ADD CONSTRAINT FK_MonAn_LoaiMonAn FOREIGN KEY(IDLoaiMonAn) REFERENCES dbo.LoaiMonAn(IDLoaiMonAn)
ALTER TABLE dbo.DanhGia ADD CONSTRAINT FK_DanhGia_MonAn FOREIGN KEY(IDMonAn) REFERENCES dbo.MonAn(IDMonAn)
ALTER TABLE dbo.HoaDon ADD CONSTRAINT FK_HoaDon_DatMon FOREIGN KEY(IDDatMon) REFERENCES dbo.DatMon(IDDatMon)
ALTER TABLE dbo.DatMon ADD CONSTRAINT FK_DatMon_NhanVien FOREIGN KEY(IDNhanvien) REFERENCES dbo.NhanVien(IDNhanVien)
ALTER TABLE dbo.DatMon ADD CONSTRAINT FK_DatMon_KhachHang FOREIGN KEY(IDKhachHang) REFERENCES dbo.KhachHang(IDKhachHang)
ALTER TABLE dbo.DatMon ADD CONSTRAINT FK_DatMon_MonAn FOREIGN KEY(IDMonAn) REFERENCES dbo.MonAn(IDMonAn)
ALTER TABLE dbo.DanhGia ADD CONSTRAINT FK_DanhGia_KhachHang FOREIGN KEY(IDKhachHang) REFERENCES dbo.KhachHang(IDKhachHang)














