--Part 1 — Database & Table Creation
CREATE DATABASE CompanyDB; 


--Employee Table Creation
CREATE TABLE Employee(
	Ssn int PRIMARY KEY,
	Fname VARCHAR(50) Not NULL,
	Minit VARCHAR(50) ,
	Lname VARCHAR(50) Not NULL,
	E_Address VARCHAR(50) Not NULL,
	Sex VARCHAR(1) NOT NULL,
	Bdate DATE NOT NULL,
	Salary DECIMAL(10,2),
);


--Department Table Creation
CREATE TABLE Department(
	department_Name VARCHAR(50) Not NULL,
	DeptNumber int PRIMARY KEY,
	NumberOfEmployees int Not NULL CHECK (NumberOfEmployees>0),
	manager_ID int,
	manager_start_date DATE NOT NULL,
	Salary DECIMAL(10,2),
	);

CREATE TABLE Department_Locations(
	DeptNumber int,
	Locations VARCHAR(50) Not NULL,
	PRIMARY KEY (DeptNumber,Locations),
	FOREIGN KEY (DeptNumber) REFERENCES Department(DeptNumber) ON DELETE CASCADE

);

--Employee Table Creation
CREATE TABLE Project(
	Pname VARCHAR(50) Not NULL,
	Pnumber int NOT NULL,
	Plocation VARCHAR(50) NOT NULL,
	PRIMARY KEY (Pnumber,Plocation)
	department_num int,
);

