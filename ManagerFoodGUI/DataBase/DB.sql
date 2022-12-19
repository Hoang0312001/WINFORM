--Food
--table
--FoodCategory
--Account
--Bill
--Bill InFO

create database ManagerFood
go

use ManagerFood
go
create table Account(

userName nvarchar(50) primary key,
fullName nvarchar(100) not null,
type int not null default 0,
status int not null default 0 
)
go

create table CategoryFood(
id int identity primary key,
name nvarchar(500) not null,
)
GO

create table Food(
id int identity primary key,
name nvarchar (500) not null ,
price int not null default 0,
idCategory int ,

Foreign key (idCategory) references dbo.CategoryFood(id)
) 
go

create table TableFood (
id int identity primary key,
name nvarchar(500) not null default N'NOT NAME',
inforBook nvarchar(500) default N'Bàn Đặt Sau',
status int not null default 0  -- 0 trống , 1 có người , 2 được đặt trước  
)
GO

create table Bill(

id int identity primary key,
dateCheckIn Date not null default GETDATE(),
dateCheckOut Date,
idTable int not null ,
status int not null default 0

Foreign key (idTable) references dbo.TableFood(id) 
) 
Go

create table BillInfo(
id int identity primary key,
idFood int not null,
idBill int not null,
TotalPrice int not null default 0

Foreign key (idFood) references dbo.Food(id), 
Foreign key (idBill) references dbo.Bill(id) 
)
go


