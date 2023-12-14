create database Academy;
go;
use Academy;
go;
create table Groups (
    Id int  primary key identity (1,1) not null,
    Name nvarchar(10) not null unique ,
    Rating int not null check (Rating >= 0 AND Rating <= 5),
    Year int not null check (Year >= 1 AND Year <= 5)
    )
    go;

create table Departments (
    Id int primary key identity (1,1) not null,
    Financing money default 0 not null check (Financing >= 0),
    Name nvarchar(100) not null unique
)

    go;

create  table Faculties (
    Id int primary key identity (1,1) not null,
    Name nvarchar(100) not null unique
);

go;
create table Teachers (
    Id int primary key identity (1,1) not null,
    EmploymentDate date not null check(EmploymentDate >= '1990-01-01'),
    Name nvarchar(max) not null,
    Premium money default 0 not null check(Premium >= 0),
    Salary money not null check (Salary > 0),
    Surname nvarchar(max) not null
)

go;





