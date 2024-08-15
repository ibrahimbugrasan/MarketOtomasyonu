--Database Çalýþtýrma
use MarketOtomasyonu
GO

--STORED PROCEDURE OLUÞTURMA
--Kullanýcý Güncelleme
create proc sp_updateUser
(
@id int,
@username nvarchar(50),
@password nvarchar(50),
@area nvarchar(50),
@email nvarchar(100),
@permission nvarchar(20),
@securityQuestion nvarchar(200),
@securityAnswer nvarchar(100)
)
as
begin
	update loginPage set username = @username, password=@password,area=@area,email=@email,permission=@permission,
	securityQuestion = @securityQuestion,securityAnswer = @securityAnswer where id = @id
end
GO

--Güvenlik Sorularýný Aktarma
create procedure guvenlikSorusuGetir_sp
as
begin
	select * from loginPage
end
GO

--Þifre Deðiþtirme
create proc changePassword_sp
(
@email nvarchar(100),
@password nvarchar(50)
)
as
begin
update loginPage set password = @password where email = @email
end
GO

--Ürün Ekleme
create proc sp_insertProducts
(
@id nvarchar(10),
@barkodkod nvarchar(50),
@olusturulma_Tarih datetime,
@guncelleme_Tarih datetime,
@urunIsim nvarchar(50),
@kilo float,
@fiyat int,
@ciro int
)
as
begin
insert into Products (id,barkodkod,olusturulma_Tarih,guncelleme_Tarih,urunIsim,kilo,fiyat,ciro)
values(@id,@barkodkod,@olusturulma_Tarih,@guncelleme_Tarih,@urunIsim,@kilo,@fiyat,@ciro)
end
GO

--Kullanýcý Ekleme
create proc sp_InsertUsers
(
@username nvarchar(50),
@password nvarchar(50),
@area nchar(50),
@email nvarchar(100),
@permission nvarchar(20),
@securityQuestion nvarchar(200),
@securityAnswer nvarchar(100)
)
as
begin
	insert into loginPage (username,password,area,email,permission,securityQuestion,securityAnswer)
	values(@username,@password,@area,@email,@permission,@securityQuestion,@securityAnswer)
end
GO

--Ürün Güncelleme
create proc sp_productsUpdate
(
@id nvarchar(10),
@barkodkod nvarchar(50),
@olusturulma_Tarih datetime,
@guncelleme_Tarih datetime,
@urunIsim nvarchar(50),
@kilo float,
@fiyat int,
@ciro int
)
as
begin
update Products set barkodkod=@barkodkod, olusturulma_Tarih=@olusturulma_Tarih,guncelleme_Tarih=@guncelleme_Tarih,urunIsim=@urunIsim,kilo=@kilo,fiyat=@fiyat,ciro=@ciro
where id=@id
end
GO