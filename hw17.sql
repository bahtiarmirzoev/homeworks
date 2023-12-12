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