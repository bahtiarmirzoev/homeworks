create database Academy

go;

use Academy;

create table Groups(
id int primary key identity (1,1),
GroupName nvarchar(10) NOT NULL,
);

go;

create table Name(
Name nvarchar(10) NOT NULL unique
);

go;

create table Rating(
Rating int not null check(Rating>=1 or Rating<=5)
);

go;

create table Year(
Year int not null check(Year>=1 or Year<=5)
);

go;

create table Departaments(
id int primary key identity (1,1),
DepartamentName nvarchar(40) NOT NULL ,

);

go;

create table  Financing(
DepartamentFinancing money default 0 constraint
check(DepartamentFinancing>=0) NOT NULL
)

go;

create table Name(
id int primary key identity (1,1),
Name nvarchar(100) NOT NULL
)

go;

create table Faculties(
id int primary key identity (1,1) NOT NUll
)

go;

create table Teachers(
id int primary key identity (1,1) NOT NULL
)

    go;

create table EmploymentDate(
EmploymentDate date constraint chk_EmploymentDate check (EmploymentDate >= '1990-01-01')not null
)

    go;

create table TeacherName(
name nvarchar(max) not null
)

    go;

create table Premium(
Premium money default 0 constraint
check(Premium>=0) NOT NULL
)
go;

create table Salary(
Salary money default 0 constraint  check(Salary>=0) not null
)
go;

create table Surname(
Surname nvarchar(max) not null
)
