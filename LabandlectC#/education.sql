create database cs31_2
use cs31_2

create table Education
( 
EducationID char(1) not null,
EducationName nvarchar(30),
constraint pk_EducationID primary key(EducationID)
)
create table Province
(
ProvinceID int not null,
ProvinceName nvarchar(30),
constraint pk_ProvinceID primary key(ProvinceID)
)
create table District
(
DistrictID int not null identity,
DistrictName nvarchar(30),
ProvinceID int not null,
constraint pk_DistrictID primary key(DistrictID),
constraint fk_ProvinceID foreign key(ProvinceID) references Province,
)
create table Ethnic
(
EthnicID int not null,
EthnicName nvarchar(30),
constraint pk_EthincID primary key(EthnicID)
)
create table Religion
(
ReligionID int not null,
ReligionName nvarchar(30),
constraint pk_ReligionID primary key(ReligionID)
)
create table Department
(
DepartmentID int not null,
DepartmentName nvarchar(30),
constraint pk_DepartmentID primary key(DepartmentID)
)
create table Position
(
PositionID int not null,
PositionName nvarchar(30),
constraint pk_PositionID primary key(PositionID)
)
create table Employee
(
EmployeeID char(10) not null,
EmployeName nvarchar(20),
SurName nvarchar(20),
Gender nchar(3),
Village nvarchar(20),
DistrictID int,
EthnicID int,
ReligionID int,
DepartmentID int ,
PositionID int,
EducationID char(1),
WorkDate date,
EmployeeStatus nchar(10),
ChildNumber int,
SpouseName nvarchar(20),
SpouseSurName nvarchar(20),
SpouseWorkType nvarchar(30),
SpouseWorkPlace nvarchar(30),
YouthData char(10),
WomenData char(10),
WelfareDate char(10),
PartyData char(10),
PhotoPath nvarchar(200),
constraint pk_Employee primary key(EmployeeID),
constraint fk_DistrictID foreign key(DistrictID) references District,
constraint fk_EthnicID foreign key(EthnicID) references  Ethnic,
constraint fk_ReligionID foreign key(ReligionID) references Religion,
constraint fk_DepartmentID foreign key(DepartmentID) references Department,
constraint fk_PositionID foreign key(PositionID) references Position,
constraint fk1_EducationID foreign key(EducationID) references Education,
)

INSERT Province
VALUES(1,N'ນະຄອນຫຼວງວຽງຈັນ'),
      (2,N'ແຂວງຜົ້ງສາລີ'),
	  (3,N'ແຂວງຫຼວງນ້ຳທາ'),
      (4,N'ແຂວງບໍ່ແກ້ວ'),
	  (5,N'ແຂວງອຸດົມໄຊ'),
      (6,N'ແຂວງຫລວງພະບາງ'),
	  (7,N'ແຂວງໄຊຍະບູລີ'),
      (8,N'ແຂວງຫົວພັນ'),
	  (9,N'ແຂວງຊຽງຂວາງ'),
      (10,N'ແຂວງວຽງຈັນ'),
	  (11,N'ແຂວງໄຊສົມບູນ'),
      (12,N'ແຂວງບໍລິຄຳໄຊ'),
	  (13,N'ແຂວງຄຳມ່ວນ'),
      (14,N'ແຂວງສະຫວັນນະເຂດ'),
	  (15,N'ແຂວງສາລະວັນ'),
      (16,N'ແຂວງຈຳປາສັກ'),
	  (17,N'ແຂວງເຊກອງ'),
      (18,N'ແຂວງອັດຕະປື')
