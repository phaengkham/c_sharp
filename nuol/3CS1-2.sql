Create database CS1_2
use CS1_2
create table Education 
(
	EducationID char(1) not null,
	EducationName nvarchar(30)
	Constraint pk_EducationID primary key(EducationID)
)
Create table Province
(
	ProvinceID int not null,
	ProvinceName nvarchar(30)
	Constraint pk_ProvinceID primary key(ProvinceID)
)
Create table District
(
	DistrictID int not null identity,
	DistrictName nvarchar(30),
	ProvinceID int,
	Constraint pk_PDistrictID primary key(DistrictID),
	constraint fk_ProvinceID foreign key(ProvinceID) references Province
)
Create table Religion
(
	ReligionID int not null,
	ReligionName nvarchar(30)
	Constraint pk_ReligionID primary key(ReligionID)
)
Create table Ethnic
(
	EthnicID int not null,
	EthnicName nvarchar(30)
	Constraint pk_EthnicID primary key(EthnicID)
)
Create table Department
(
	DepartmentID int not null,
	DepartmentName nvarchar(30)
	Constraint pk_DepartmentID primary key(DepartmentID)
)
Create table Position
(
	PositionID int not null,
	PositionName nvarchar(30)
	Constraint pk_PositionID primary key(PositionID)
)
Create table Employee
(
	EmployeeID char(10) not null,
	EmployeeName nvarchar(20),
	Surname nvarchar(20),
	Gender nchar(3),
	dob date,
	Village nvarchar(20),
	DistrictID int,
	EthnicID int,
	ReligionID int,
	DepartmentID int,
	PositionID int,
	EducationID char(1),
	WorkDate date,
	EmployeeStatus nchar(10),
	ChildNumber int,
	SpouseName  nvarchar(20),
	SpouseSurname nvarchar(20),
	SpouseWorkType nvarchar(30),
	SpouseWorkPlace nvarchar(30),
	YouthDate char(10),
	WomenDate char(10),
	WelfareDate char(10),
	PartyDate char(10),
	PhotoPath nvarchar(200),
	Constraint pk_EmployeeID primary key(EmployeeID),
	Constraint fk_EthnicID foreign key(EthnicID) references Ethnic,
	Constraint fk_ReligionID foreign key(ReligionID) references Religion,
	Constraint fk_DepartmentID foreign key(DepartmentID) references Department,
	Constraint fk_PositionID foreign key(PositionID) references Position,
	Constraint fk_EducationID foreign key(EducationID) references Education,
	Constraint fk_DistrictID foreign key(DistrictID) references District,
)
Drop table Employee