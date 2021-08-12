create table inventory(
ProductId INT PRIMARY KEY Identity(1,1),
ProdName varchar(50) NOT NULL,
ProdPrice decimal(8,2) NOT NULL,
);
create table sales(
SalesId INT PRIMARY KEY Identity(1,1),
SalesPerson int NOT NULL,
ProductId int NOT NULL,
SaleDate date NOT NULL,
CONSTRAINT FK_SalesPerson FOREIGN KEY (SalesPerson) REFERENCES employee(EmployeeId),
CONSTRAINT FK_ItemId FOREIGN KEY (ProductId) REFERENCES inventory(ProductId),
);
create table employee(
EmployeeId INT PRIMARY KEY Identity(1,1), 
EmpName varchar(50) NOT NULL,
EmpLastName varchar(50) NOT NULL,
EmpType varchar(10) NOT NULL,
Email varchar(50) CONSTRAINT ckEmail CHECK(Email LIKE '_%@__%.__%'),
CommisionPer decimal(4,2) NULL
);
insert into inventory values ('Audi',835689.00),('TATA',296588.00),('Hyundai',895672.00),('Suzuki',589742.00),('Tesla',85285);

insert into employee values ('dhruvit','diyora','Sales',12.20),('leo','messi','Manager',10.00),('sergio','ramos','marketing',2.20),('kylian','mbappe','Sales',12.20);

insert into sales values (2,3),(2,2),(3,2),(2,5);