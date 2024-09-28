create database DB_QL_NHASACH_NHOM1
USE DB_QL_NHASACH_NHOM1
GO
CREATE TABLE THELOAISANPHAM
(
    MaLoai varchar(20) PRIMARY KEY NOT NULL,
    TenLoai nvarchar(50)
)
-- [Thêm các dòng INSERT cho THELOAISANPHAM ở đây]
INSERT INTO THELOAISANPHAM VALUES
('MS02',N'Sách văn học'),
('MS03',N'Sách kinh tế'),
('MS04',N'Truyện tranh'),
('MS05',N'Sách thiếu nhi'),
('SP01',N'Văn phòng phẩm và dụng cụ'),
('SP02',N'Lưu niệm'),
('SP03',N'Đồ chơi'),
('SP04',N'Băng đĩa')

-- Tạo bảng TACGIA
CREATE TABLE TACGIA
(
    MaTacGia varchar(20),
    TenTacGia nvarchar(50) NOT NULL,
    DiaChi nvarchar(50),
    CONSTRAINT PK_TACGIA PRIMARY KEY (MaTacGia)
)
-- [Thêm các dòng INSERT cho TACGIA ở đây]

INSERT INTO TACGIA VALUES
('TG01',N'Nguyễn Thi',N'TP Hồ Chí Minh'),
('TG02',N'Nguyễn Bảo',N'TP Hà Nội'),
('TG03',N'Duy Khán',N'TP Hồ Chí Minh'),
('TG04',N'Võ Hồng',N'Đà Nẵng'),
('TG05',N'Lê Phương Liên',N'Quảng Nam'),
('TG06',N'Nguyễn Đỗ An Nhiên',N'TP Bà Rịa-Vũng Tàu'),
('TG07',N'Anh Huỳnh',N'Cà Mau'),
('TG08',N'Hà Triều',N'TP Hà Nội'),
('TG09',N'Xuân Diệu',N'Hà Tĩnh'),
('TG10',N'Nguyễn Vĩnh Nguyên',N'Nghệ An')
-- Tạo bảng NHAPHANPHOI
CREATE TABLE NHAPHANPHOI
(
    MaNPP varchar(20),
    TenNPP nvarchar(100) NOT NULL,
    DiaChi nvarchar(200),
    CONSTRAINT PK_NPP PRIMARY KEY (MaNPP)
)
-- [Thêm các dòng INSERT cho NHAPHANPHOI ở đây]
INSERT INTO NHAPHANPHOI VALUES
('NPP01',N'Phương Nam',N'231 Đ. Nguyễn Văn Cừ, Phường 4, Quận 5, Thành phố Hồ Chí Minh'),
('NPP02',N'NXB Trẻ',N'161B Lý Chính Thắng, Võ Thị Sáu, Quận 3, Thành phố Hồ Chí Minh'),
('NPP03',N'NXB Kim Đồng',N'Số 55 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội'),
('NPP06',N'Công Ty TNHH MTV Sản Xuất Thương Mại Dịch Vụ Hoa Sen Hồng',N'326B/25 Kp. Nội Hóa 1, P. Bình An, TX. Dĩ An,Bình Dương'),
('NPP07',N'Công Ty TNHH Sản Xuất Thương Mại Hoàng Gia Sơn',N'192/49 Nguyễn Oanh, P. 17, Q. Gò Vấp,Tp. Hồ Chí Minh'),
('NPP08',N'Thiết Bị Vui Chơi Tân Phát',N'Số 86, Dãy 2, Tổ 109, P. Vĩnh Tuy, Q. Hai Bà Trưng,Hà Nội'),
('NPP09',N'Thiết Bị Mầm Non Ân Hồng Hạnh',N'176A Đường Điện Biên Phủ, P. Chính Gián, Q. Thanh Khê,Tp. Đà Nẵng')
-- Tạo bảng NHANVIEN

CREATE TABLE NHANVIEN
(
    MaNV varchar(20),
    TenNV nvarchar(50) NOT NULL,
    DiaChi nvarchar(50),
    CONSTRAINT PK_NHANVIEN PRIMARY KEY (MaNV)
)
-- [Thêm các dòng INSERT cho NHANVIEN ở đây]

insert into NHANVIEN VALUES
('QL001',N'Hà Thị Minh Thư',N'64/7 Nguyễn Đỗ Cung,Tân Phú,TP Hồ Chí Minh'),
('QL002',N'Hà Văn Thy',N'237 Tân Kỳ Tân Quý,Tân Sơn Nhì,TP Hồ Chí Minh'),
('NV001',N'Mai Dương Bá Đạt',N'TP.Thuận An, Bình Dương'),
('NV002',N'Nguyễn Thanh Thảo',N'H.Củ Chi, TP Hồ Chí Minh'),
('NV003',N'Phạm Đức Dũng',N'383 Quan Trung, Gò Vấp, TP Hồ Chí Minh')
-- Tạo bảng SANPHAM
CREATE TABLE SANPHAM
(
    MaSP varchar(20),
    TenSP nvarchar(100),
    DonGia float,
    MoTa nvarchar(300),
    NgayCapNhat date,
    SoLuong int,
    MaLoai varchar(20),
    MaNPP varchar(20),
    MaTacGia varchar(20),
    CONSTRAINT PK_Sach PRIMARY KEY (MaSP),
    CONSTRAINT FK_SANPHAM_THELOAI FOREIGN KEY (MaLoai) REFERENCES THELOAISANPHAM(MaLoai) on delete set null,
    CONSTRAINT FK_SANPHAM_NPP FOREIGN KEY (MaNPP) REFERENCES NHAPHANPHOI(MaNPP) on delete set null,
    CONSTRAINT FK_SANPHAM_TACGIA FOREIGN KEY (MaTacGia) REFERENCES TACGIA(MaTacGia) on delete set null
)
-- [Thêm các dòng INSERT cho SANPHAM ở đây]
set dateformat dmy
INSERT INTO SANPHAM
VALUES
('SP001', N'NGƯỜI MẸ CẦM SÚNG', 36000, N'Bức chân dung sống động, giản dị về người mẹ Nam Bộ bất khuất, trung hậu, đảm đang, hết lòng vì con cái và sẵn sàng quên mình vì quê hương đất nước…', '24/07/2019', 50, 'MS02', 'NPP03', 'TG01'),
('SP002', N'CHUYỆN KỂ TRƯỚC GIỜ ĐI NGỦ - NÔNG TRẠI HOA ĐẬU BIẾC', 58500, N'Chú mèo Lọ Nghẹ cùng chị chủ về nghỉ Hè ở nông tại Hoa Đậu Biếc. Tại đây, mèo soái ca kết thân với mèo Cá Rô, khám phá khung cảnh thôn quê tươi đẹp, tiếp tục lập nên các chiến công mới.', '19/11/2022', 70, 'MS02', 'NPP03', 'TG02'),
('SP003', N'TUỔI THƠ IM LẶNG', 49500, N'Đang từ một người làm thơ, Duy Khán chuyển sang văn xuôi. Đang từ một người dễ dãi chạy theo các đề tài thời sự, Duy Khán trở lại với cái phần kí ức tuổi thơ nằm sâu và đã trở nên bền chặt trong tâm trí. ', '01/01/2019', 60, 'MS02', 'NPP03', 'TG03'),
('SP004', N'TUỔI THƠ ÊM ĐỀM',45000, N'Khi nhà văn nói điều này, tôi hiểu ở anh, nhân ái không chút vướng mắc tội nghiệp hoặc ru ngủ trẻ.', '02/05/2023', 100, 'MS02', 'NPP03', 'TG04'),
('SP005', N'NHỮNG TIA NẮNG ĐẦU TIÊN', 45000, N'Cuốn sách của tình người, tình bạn của những thiếu niên khi mới chạm đến ngưỡng cửa tuổi xuân. ', '09/12/2022', 80, 'MS02', 'NPP03', 'TG05'),
('SP006', N'QUẢN TRỊ INAMORI - MỖI NHÂN VIÊN ĐỀU ĐÓNG VAI TRÒ CHÍNH', 110000 , N'Quản trị Inamori (còn gọi là quản trị amooeba) là hệ thống quản trị  tạo ra lợi nhuận cao trong suốt nửa thế kỷ bất kể biến động thị trường.', '27/05/2023', 60, 'MS03', 'NPP02', 'TG06'),
('SP007', N'NGHĨ THIỆN ĐỂ CUỘC ĐỜI VÀ CỒNG VIỆC VIÊN MÃN', 70000 , N'Nghĩ thiện - Để cuộc đời và công việc viên mãn gồm 10 chương với các những dòng tâm tình chân thành của tác giả dành cho bạn đọc.', '30/11/2019', 120, 'MS03', 'NPP02', 'TG06'),
('SP008', N'KHÔNG CÓ TRẺ HƯ - HIỂU VÀ PHÁT HUY KHÍ CHẤT CON BẠN THEO KIỂU NHẬT BẢN', 115000 , N'Takeuchi Erika là nhà giáo dục nuôi dạy trẻ - Giáo viên thỉnh giảng trường Đại học Shutoku. Chủ tịch Hội Kids Coaching Nhật Bản, bà có 2 con.', '19/09/2019', 40, 'MS03', 'NPP02', 'TG06'),
('SP009', N'SOUL EATER 2', 95000 , N'Câu chuyện kể về cuộc phiêu lưu của Maka Albarn và vũ khí lưỡi hái khổng lồ của cô, Soul Eater..', '31/10/2019', 120, 'MS04', 'NPP01', 'TG07'),
('SP010', N'FIRE FORCE 16', 43000  , N'Truyện lấy bối cảnh thế giới khi con người đối mặt với hiện tượng “nhân thể bộc hỏa”, tức con người tự bốc cháy.', '30/11/2023', 120, 'MS04', 'NPP01', 'TG07'),
('SP011', N'THẾ GIỚI GIÁC QUAN KỲ THÚ ', 30000 , N'Tại sao chúng ta nhìn thấy được vạn vật quanh mình? Làm sao chúng ta có thể nghe được các loại âm thanh? ', '10/01/2022', 120, 'MS05', 'NPP02', 'TG08'),
('SP012', N'MÙI GÌ THƠM THẾ?', 30000  , N'Tại sao chúng ta nhìn thấy được vạn vật quanh mình? Làm sao chúng ta có thể nghe được các loại âm thanh? Tại sao khi tịt mũi, ', '15/10/2023', 120, 'MS05', 'NPP02', 'TG08'),
('SP014', N'Máy tính để bàn Vinacal DC-12', 276250 , N'- Nguồn năng lượng hai chiều (Mặt trời + Pin) Chế độ sử dụng năng lượng mặt trời được bật khi đủ sáng, chế độ pin được bật khi không đủ sáng.', '17/01/2023', 150, 'SP01', 'NPP06', null),
('SP015', N'Giấy note', 15000 , N'Ghi chép những lưu ý trên nền giấy note', '21/08/2023', 200, 'SP01', 'NPP06', null),
('SP016', N'Viết chì bấm Yz', 33000 , N'Hình dạng cây cà rốt phù hợp cho trẻ nhỏ, ngòi chì không gãy', '25/11/2022', 100, 'SP01', 'NPP06',NULL),
('SP017', N'Chậu thông trang trí 60CM', 395000 , N'Chất liệu: Khung kim thân cây loại chắc chắn không lo cong vẹo, lá nhỏ PVC được phủ xốp tuyết hiện đại. Đế gỗ vững vàng được bọc ngoài lớp vải cách điệu tinh tế.', '30/10/2023', 40, 'SP02', 'NPP07', NULL)
,('SP018',N'Lịch vạn niên',240000,N'Chất liệu 100% cotton thân thiện với môi trường, mẫu mã đẹp bắt mắt','09/09/2023',200,'SP02','NPP07',NULL)
,('SP019',N'BARBIE Búp bê Đổi Màu- Phiên bản Thời Trang Picnic HKT81',499000,N'Với 6 điều bất ngờ, búp bê Barbie® Chelsea™ Color Reveal™ mang đến nhiều điều thú vị -- khám phá Chuỗi dã ngoại với Cải tiến mới!','24/08/2022',100,'SP03','NPP08',NULL)
,('SP020',N'BEYBLADE 6 Con Quay B-180 Booster Dynamite 173670',322150,N'- Phù hợp cho trẻ từ 6 tuổi.Chất liệu nhựa và kim loại tạo độ cứng cáp cho sản phẩm','01/08/2022',70,'SP03','NPP08',NULL)
,('SP021',N'CD-Làn sóng xanh',380000,N'Đĩa không xước','15/05/2022',70,'SP04','NPP09',NULL),
('SP022',N'CD Phương Phương Thảo - Lệ Xa Người',380000,N'CD PHƯƠNG PHƯƠNG THẢO - LỆ XA NGƯỜI Album vol 3 “Lệ xa người” là cd mới nhất của nữ ca sĩ Phương Phương Thảo','15/07/2023',90,'SP04','NPP09',NULL)

-- Tạo bảng TAIKHOAN
CREATE TABLE TAIKHOAN
(    
    MaTK varchar(20) PRIMARY KEY NOT NULL,
    MaNV varchar(20) NOT NULL,
    TenDangNhap varchar(50),
    MatKhau varchar(50),
    Quyen nvarchar(50),
    CONSTRAINT FK_TAIKHOAN_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN (MaNV)
)
-- [Thêm các dòng INSERT cho TAIKHOAN ở đây]

INSERT INTO TAIKHOAN VALUES
('TK01','QL001','Admin','12345',N'Admin'),
('TK02','QL002','Admin','123456',N'Admin'),
('TK03','NV001','NV001','123',N'NhanVien'),
('TK04','NV002','NV002','123',N'NhanVien'),
('TK05','NV003','NV003','12345',N'NhanVien')
-- Tạo bảng HOADON
CREATE TABLE HOADON
(
    MaHD varchar(20) PRIMARY KEY NOT NULL,
    NgayLap DATE,
    MaNV varchar(20),
    CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
) 
-- [Thêm các dòng INSERT cho HOADON ở đây]
SET DATEFORMAT dmy
INSERT INTO HOADON
VALUES
('HD001', '24/07/2023', 'NV003'),
('HD002', '20/09/2023', 'NV001'),
('HD003', '14/08/2023', 'NV003'),
('HD004', '19/10/2023', 'NV001'),
('HD005', '25/10/2023', 'NV002')
-- Tạo bảng PHIEUNHAP
CREATE TABLE PHIEUNHAP
(
    MaPhieuNhap CHAR(10) PRIMARY KEY,
    NgayTaoPhieu DATE,
    MaNPP varchar(20),
    CONSTRAINT FK_PHIEUNHAP_NHAPHANPHOI FOREIGN KEY (MaNPP) REFERENCES NHAPHANPHOI(MaNPP)
)
-- [Thêm các dòng INSERT cho PHIEUNHAP ở đây]
set dateformat dmy
INSERT INTO PHIEUNHAP(MaPhieuNhap,NgayTaoPhieu,MaNPP) 
VALUES
('PN001', '20/07/2023', 'NPP01'),
('PN002', '22/05/2023','NPP02'),
('PN003', '28/02/2023', 'NPP03'),
('PN004', '10/03/2023','NPP02'),
('PN005', '15/07/2023', 'NPP06')
-- Tạo bảng CHITIETHOADON
CREATE TABLE CHITIETHOADON
(
    MaHD varchar(20), 
    MaSP varchar(20),
    SoLuong INT,
    CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MaHD, MaSP),
    CONSTRAINT FK_CHITIETHOADON_HOADON FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD),
    CONSTRAINT FK_CHITIETHOADON_SANPHAM FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)
)
-- [Thêm các dòng INSERT cho CHITIETHOADON ở đây]
INSERT INTO CHITIETHOADON(MaHD, MaSP, SoLuong)
VALUES
('HD001', 'SP001', 5),
('HD002', 'SP002', 2),
('HD003', 'SP003', 4),
('HD004', 'SP004', 5),
('HD005', 'SP005', 6)
-- Tạo bảng CHITIETPHIEUNHAP
CREATE TABLE CHITIETPHIEUNHAP
(
    MaPhieuNhap CHAR(10),
    MaSP varchar(20),
    SoLuong INT not null,
	GiaNhap float not null,
	CONSTRAINT PK_CHITIETPHIEUNHAP PRIMARY KEY (MaPhieuNhap, MaSP),
    CONSTRAINT FK_CHITIETPHIEUNHAP_PHIEUNHAP FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAP(MaPhieuNhap) ON DELETE CASCADE,
    CONSTRAINT FK_CHITIETPHIEUNHAP_SANPHAM FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP) ON DELETE CASCADE
)
INSERT INTO CHITIETPHIEUNHAP(MaPhieuNhap, MaSP,GiaNhap, SoLuong)
VALUES
('PN001', 'SP001', 20000, 2),
('PN002', 'SP002', 50000, 5)
SELECT *FROM SANPHAM
--------THE LOAI 
CREATE PROC proc_ThemTheLoai
    @maLoai varchar(20),
    @tenLoai nvarchar(100)
AS
BEGIN
    INSERT INTO THELOAISANPHAM (MaLoai, TenLoai)
    VALUES (@maLoai, @tenLoai)
END

CREATE PROC proc_CapNhatLoaiSach
 @maLoai varchar(20),
 @tenLoai nvarchar(100)
 as 
 begin
	update THELOAISANPHAM 
	set TenLoai=@tenLoai
	where MaLoai=@maLoai
	end
------TACGIA
CREATE PROC proc_ThemTacGia
@maTG varchar(20),
@tenTG nvarchar(50),
@diaChi nvarchar(100)
as
begin
insert into TACGIA(MaTacGia, TenTacGia, DiaChi) values(@maTG, @tenTG, @diaChi)
end

CREATE PROC proc_CapNhatTacGia
@maTG varchar(20),
@tenTG nvarchar(50),
@diaChi nvarchar(100)
 as 
 begin
	update TACGIA 
	set TenTacGia=@tenTG,DiaChi=@diaChi
	where MaTacGia=@maTG
	end
	
------PHIEU NHAP
create proc pro_themPhieuNhap
@maPN varchar(20),@ngayTaoPhieu datetime, @nhaPP nvarchar(100)
as 
begin
insert into PHIEUNHAP(MaPhieuNhap, NgayTaoPhieu, MaNPP) values (@maPN,@ngayTaoPhieu, @nhaPP)
end

CREATE PROC proc_CapNhatPhieuNhap
@maPN varchar(20),
@ngayTaoPhieu datetime,
@maNPP nvarchar(100)
 as 
 begin
	update PHIEUNHAP 
	set NgayTaoPhieu=@ngayTaoPhieu,MaNPP=@maNPP
	where MaPhieuNhap=@maPN
	end

select *from CHITIETPHIEUNHAP
--CHI TIET PHIEU NHAP
create PROC proc_ThemChiTietPhieuNhap
	@maPhieuNhap varchar(20), @maSanPham varchar(20), @soLuong int, @giaNhap float
as
 begin
	insert into CHITIETPHIEUNHAP values (@maPhieuNhap, @maSanPham, @soLuong, @giaNhap)
end

CREATE PROC proc_CapNhatChiTietPhieuNhap
@maPhieuNhap varchar(20), @maSanPham varchar(20), @soLuong int, @giaNhap float
 as 
 begin
	update CHITIETPHIEUNHAP 
	set SoLuong=@soLuong,GiaNhap=@giaNhap
	where MaPhieuNhap=@maPhieuNhap and MaSP= @maSanPham
end
ALTER TABLE CHITIETPHIEUNHAP
DROP CONSTRAINT FK_CHITIETPHIEUNHAP_PHIEUNHAP;

select *from PHIEUNHAP

alter table NHANVIEN 
ADD Email varchar(50)


alter table CHITIETHOADON
ADD TongTien float


select * from CHITIETHOADON