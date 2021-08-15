﻿CREATE DATABASE QLNS


CREATE TABLE NHANVIEN
(
	MANV int NOT NULL PRIMARY KEY identity,
	TENNV NVARCHAR(60),
	AVATAR NVARCHAR(200)  DEFAULT 'Anonymous.png',
	NGAYVAOLAM DATETIME,
	GIOITINH BIT NOT NULL,
	PHONGBAN NVARCHAR(60) NOT NULL,
	LOAICONGVIEC NVARCHAR(60) NOT NULL,
)

CREATE TABLE LUONG
(
	MALUONG int NOT NULL PRIMARY KEY identity,
	LUONGCOBAN FLOAT DEFAULT 0,
	HESOLUONG FLOAT DEFAULT 0,
	LUONG1GIO FLOAT DEFAULT 0,
	LUONG1NGAY FLOAT DEFAULT 0,
	SONGAYLAM INT DEFAULT 0,
	SOGIOLAM INT DEFAULT 0,
	LUONGTHUONG INT DEFAULT 0,
	THANHLUONG FLOAT DEFAULT 0,
	MANV int NOT NULL
)

CREATE TABLE [USER]
(
	IDUSER int NOT NULL PRIMARY KEY identity,
	FULLNAME NVARCHAR(200),
	AVATAR NVARCHAR(200) DEFAULT 'Anonymous.png',
	USERNAME NVARCHAR(200) NOT NULL UNIQUE,
	[PASSWORD] NVARCHAR(200) NOT NULL
)

CREATE TABLE [ROLE]
(
	IDROLE int NOT NULL PRIMARY KEY identity,
	USERNAME NVARCHAR(200) NOT NULL,
	ROLECODE NVARCHAR(200) NOT NULL,
)

ALTER TABLE LUONG
ADD CONSTRAINT FK_LUONG_MANV_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
ON UPDATE CASCADE ON DELETE CASCADE

ALTER TABLE [ROLE]
ADD CONSTRAINT FK_ROLE_USERNAME_USER FOREIGN KEY (USERNAME) REFERENCES [USER](USERNAME)
ON UPDATE CASCADE ON DELETE CASCADE



INSERT INTO [USER](FULLNAME, USERNAME, [PASSWORD]) VALUES(N'Nguyễn Anh', 'CEO', '1')
INSERT INTO [USER](FULLNAME, USERNAME, [PASSWORD]) VALUES(N'Trần Quang', 'HR','1')
INSERT INTO [USER](FULLNAME, USERNAME, [PASSWORD]) VALUES(N'Lý Đông', 'PR', '1')



INSERT INTO [ROLE] VALUES('CEO', 'CEO')
INSERT INTO [ROLE] VALUES('CEO', 'MANAGER_HR')
INSERT INTO [ROLE] VALUES('CEO', 'MANAGER_PR')
INSERT INTO [ROLE] VALUES('HR', 'MANAGER_HR')
INSERT INTO [ROLE] VALUES('PR', 'MANAGER_PR')

SELECT SUM(L.THANHLUONG) FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV 
SELECT COUNT(*) FROM NHANVIEN WHERE GIOITINH = 0
SELECT SUM(L.THANHLUONG) FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND N.GIOITINH = 0
SELECT SUM(L.THANHLUONG) FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND PHONGBAN = N'Kế toán'