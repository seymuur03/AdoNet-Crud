CREATE DATABASE HomeWork_AdoNet
USE HomeWork_AdoNet

CREATE TABLE Students
(
Id int primary key identity,
[Name] nvarchar(30),
Age int,
GroupId int foreign key references Groups(Id)
)
SELECT * FROM Students

CREATE TABLE Groups
(
Id int primary key identity,
[Name] nvarchar(30)
)
SELECT * FROM Groups


CREATE TABLE StudentDetails
(
Id int primary key identity,
Adress nvarchar(30),
PhoneNumber nvarchar(30),
StudentId int foreign key references Students(Id)
)
SELECT * FROM StudentDetails

CREATE TABLE Courses
(
Id int primary key identity,
[Name] nvarchar(30)
)
SELECT * FROM Courses

CREATE TABLE StudentCourses
(
Id int primary key identity,
StudentId int foreign key references Students(Id),
CourseId int foreign key references Courses(Id)
)
SELECT * FROM StudentCourses

--OneToOne releation ucun view
CREATE VIEW StudentWithDetails
AS
SELECT s.*,sd.Adress,sd.PhoneNumber FROM Students s
JOIN 
StudentDetails sd
ON 
sd.StudentId = s.Id
SELECT * FROM StudentWithDetails
