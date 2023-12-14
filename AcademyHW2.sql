use [Academy];

--1 Sort
select *from [Departments] order by  [Id] desc
--
go;
-- 2 Group name and ratings
select [Name], [Rating] from [Groups]
--
go;
--3 otnoshenie nadbavka
select [Surname] , ([Premium] / [Salary] * 100) as 'Percent Of Premium Rate' , (1 + [Premium]/[Salary]) * 100 as 'Percent Of Total Rate' from [Teachers]
--
go;
--4 concat
select concat('The Dean Of Faculty : ', [Name], ' is ', [Dean], '.') as 'Faculty Info' from [Faculties]
--
go;
--5 Professor 1050+
select *from [Teachers] [Surname] where [Salary] > 1050 and [IsProfessor] = 1
--
go;
--6
select [Name] from [Departments] where [Financing] > 25000 or [Financing] < 11000
--
go;
--7
select [Name] FROM [Faculties] where [Name] != 'Computer Science'
--
go;
--8
select [Surname], [Position] from [Teachers] where [IsProfessor] = 0
--
go;
select [Surname] , [Position], [Salary] , [Premium] from [Teachers] where [IsAssistant] = 1 and [Premium] between 160 and 550
--10
select [Surname] , [Position] from [Teachers] where [IsAssistant] = 1
--
go;
--11
select [Surname] , [Position] from [Teachers] where [EmploymentDate] < '2000-01-01'
--
go;
--12
--
go;
select [Name] from [Departments] where [Name] < 'Software Development' order by [Name] asc
--13
select [Surname] from [Teachers] where [IsAssistant] = 1 and [Salary] + [Premium] <= 1200
--
go;
--14
select [Name] from [Groups] where [Year] = 5 and [Rating] < 5 and [Rating] > 1
--
go;
--15
select [Surname], [Salary] from [Teachers] where [IsAssistant] = 1 and ([Salary] < 550 or [Premium] < 200)
--





