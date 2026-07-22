--Part 1 — Database & Table Creation
CREATE DATABASE CompanyDB; 


--Employee Table Creation
CREATE TABLE Employee(
	Ssn int PRIMARY KEY,
	Fname VARCHAR(50) Not NULL,
	Minit VARCHAR(50) ,
	Lname VARCHAR(50) Not NULL,
	Address VARCHAR(50) Not NULL,
	Sex VARCHAR(1) NOT NULL,
	Bdate DATE NOT NULL,
	Salary DECIMAL(10,2)
	supervisor_ID int FOREIGN KEY,
	department_NUM int FOREIGN KEY,

)