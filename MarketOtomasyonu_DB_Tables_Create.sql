--Veritabaný Oluþturma
create database MarketOtomasyonu
GO

--Veritabanýný Kullanma
use MarketOtomasyonu
GO

--Tablolarý Oluþturma
create table Products(
id nvarchar(10) primary key,
qrkod nvarchar(50),
barkodkod nvarchar(50) NOT NULL unique,
olusturulma_Tarih datetime NOT NULL,
guncelleme_Tarih datetime,
urunIsim nvarchar(50) NOT NULL,
kilo float NOT NULL,
fiyat int NOT NULL,
ciro int)
GO

create table loginPage(
id int primary key,
username nvarchar(50) NOT NULL unique,
password nvarchar(50) NOT NULL,
area nchar(50),
email nvarchar(100) NOT NULL unique,
permission nvarchar(20) NOT NULL,
securityQuestion nvarchar(200) NOT NULL,
securityAnswer nvarchar(100) NOT NULL)
GO


