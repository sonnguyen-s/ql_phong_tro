USE [quanlyphongtro]
GO
/****** Object:  Table [dbo].[danhSachDichVu]    Script Date: 11/16/2021 7:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danhSachDichVu](
	[tenDichVu] [nvarchar](100) NOT NULL,
	[donViTinh] [nvarchar](100) NOT NULL,
	[donGia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonDichVu]    Script Date: 11/16/2021 7:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonDichVu](
	[maHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[maPhong] [nvarchar](100) NOT NULL,
	[tenDichVu] [nvarchar](100) NOT NULL,
	[soLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonTong]    Script Date: 11/16/2021 7:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonTong](
	[maHoaDonTong] [int] IDENTITY(1,1) NOT NULL,
	[maPhong] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoaDonTong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 11/16/2021 7:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong](
	[maPhong] [nvarchar](10) NOT NULL,
	[trangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 11/16/2021 7:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tenDangNhap] [nvarchar](100) NOT NULL,
	[tenHienThi] [nvarchar](100) NOT NULL,
	[matKhau] [nvarchar](100) NOT NULL,
	[quyenHan] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[danhSachDichVu] ([tenDichVu], [donViTinh], [donGia]) VALUES (N'Điện', N'kw', 5000)
INSERT [dbo].[danhSachDichVu] ([tenDichVu], [donViTinh], [donGia]) VALUES (N'Gas', N'Bình', 385000)
INSERT [dbo].[danhSachDichVu] ([tenDichVu], [donViTinh], [donGia]) VALUES (N'Giữ xe', N'Tháng', 50000)
INSERT [dbo].[danhSachDichVu] ([tenDichVu], [donViTinh], [donGia]) VALUES (N'Nước', N'm3', 6000)
GO
SET IDENTITY_INSERT [dbo].[hoaDonDichVu] ON 

INSERT [dbo].[hoaDonDichVu] ([maHoaDon], [maPhong], [tenDichVu], [soLuong]) VALUES (9, N'1B', N'Điện', 5)
INSERT [dbo].[hoaDonDichVu] ([maHoaDon], [maPhong], [tenDichVu], [soLuong]) VALUES (10, N'1B', N'Nước', 7)
INSERT [dbo].[hoaDonDichVu] ([maHoaDon], [maPhong], [tenDichVu], [soLuong]) VALUES (11, N'1B', N'Điện', 5)
INSERT [dbo].[hoaDonDichVu] ([maHoaDon], [maPhong], [tenDichVu], [soLuong]) VALUES (12, N'1B', N'Nước', 5)
SET IDENTITY_INSERT [dbo].[hoaDonDichVu] OFF
GO
INSERT [dbo].[phong] ([maPhong], [trangThai]) VALUES (N'1A', N'Trống')
INSERT [dbo].[phong] ([maPhong], [trangThai]) VALUES (N'1B', N'Đã được thuê')
INSERT [dbo].[phong] ([maPhong], [trangThai]) VALUES (N'2A', N'Đã được thuê')
GO
INSERT [dbo].[taikhoan] ([tenDangNhap], [tenHienThi], [matKhau], [quyenHan]) VALUES (N'Admin', N'Admin', N'1', N'Admin')
INSERT [dbo].[taikhoan] ([tenDangNhap], [tenHienThi], [matKhau], [quyenHan]) VALUES (N'hieu', N'hiếu', N'2', N'Nhân viên')
INSERT [dbo].[taikhoan] ([tenDangNhap], [tenHienThi], [matKhau], [quyenHan]) VALUES (N'Nhan', N'NhânNhan', N'2', N'Nhân viên')
GO
ALTER TABLE [dbo].[hoaDonDichVu]  WITH CHECK ADD FOREIGN KEY([tenDichVu])
REFERENCES [dbo].[danhSachDichVu] ([tenDichVu])
GO
ALTER TABLE [dbo].[hoaDonTong]  WITH CHECK ADD FOREIGN KEY([maPhong])
REFERENCES [dbo].[phong] ([maPhong])
GO
