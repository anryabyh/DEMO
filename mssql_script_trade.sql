
create table [Role]
(
	RoleID int primary key identity,
	RoleName nvarchar(100) not null
)
go
create table [User]
(
	UserID int primary key identity,
	UserSurname nvarchar(100) not null,
	UserName nvarchar(100) not null,
	UserPatronymic nvarchar(100) not null,
	UserLogin nvarchar(max) not null,
	UserPassword nvarchar(max) not null,
	UserRole int foreign key references [Role](RoleID) not null
)
go
create table PickupPoint(
PickupPointID int primary key identity,
TitlePickupPoint nvarchar(max) not null,
TimeStart DATETIME,
TimeEnd DateTime,
)

create table [Order]
(
	OrderID int primary key identity,
	OrderStatus nvarchar(max) not null,
	OrderDeliveryDate datetime not null,
	OrderPickupPoint int foreign key references PickupPoint(PickupPointID) not null
)
go
create table Product
(
	ProductArticleNumber nvarchar(100) primary key,
	ProductName nvarchar(max) not null,
	ProductDescription nvarchar(max) not null,
	ProductCategory nvarchar(max) not null,
	ProductPhoto image not null,
	ProductManufacturer nvarchar(max) not null,
	ProductCost decimal(19,4) not null,
	ProductDiscountAmount decimal,
	ProductQuantityInStock int not null,
	ProductStatus nvarchar(max) not null,
)
go
create table OrderProduct
(
	OrderID int foreign key references [Order](OrderID) not null,
	ProductArticleNumber nvarchar(100) foreign key references Product(ProductArticleNumber) not null,
	Primary key (OrderID,ProductArticleNumber)
)
