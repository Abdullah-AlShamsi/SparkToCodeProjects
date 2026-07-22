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
	Salary DECIMAL(10,2) NOT NULL
);


--Department Table Creation
CREATE TABLE Department(
	department_Name VARCHAR(50) Not NULL,
	DeptNumber int PRIMARY KEY,
	NumberOfEmployees int Not NULL CHECK (NumberOfEmployees>0),
	Salary DECIMAL(10,2)
	);

CREATE TABLE Department_Locations(
	DeptNumber int,
	Locations VARCHAR(50) Not NULL,
	PRIMARY KEY (DeptNumber,Locations),
	FOREIGN KEY (DeptNumber) REFERENCES Department(DeptNumber) ON DELETE CASCADE

);

--Project Table Creation
CREATE TABLE Project(
	Pname VARCHAR(50) Not NULL,
	Pnumber int NOT NULL,
	Plocation VARCHAR(50) NOT NULL,
	PRIMARY KEY (Pnumber,Plocation)
);

--Works_On Table Creation 
CREATE TABLE Works_On(
	E_Ssn int NOT NULL,
	P_number int NOT NULL,
	Works_On_Hours DECIMAL(10,2) NOT NULL
);

--Dependent Table Creation 
CREATE TABLE Dependent(
	E_Ssn int NOT NULL,
	Dependent_name VARCHAR(50) NOT NULL,
	Sex VARCHAR(1) NOT NULL,
	Bdate DATE NOT NULL,
	Relationship VARCHAR(50) NOT NULL,
	PRIMARY KEY (E_Ssn,Dependent_name),
	FOREIGN KEY (E_Ssn) REFERENCES Employee(Ssn) ON DELETE CASCADE
);

-- Add FOREIGN KEYs:
ALTER TABLE Employee
ADD D_number int;

ALTER TABLE Employee
ADD FOREIGN KEY (D_number) REFERENCES Department(DeptNumber);

ALTER TABLE Employee
ADD supervisor_Ssn int;

ALTER TABLE Employee
ADD FOREIGN KEY (supervisor_Ssn) REFERENCES Employee(Ssn);

ALTER TABLE Department
ADD manager_Ssn int;
ALTER TABLE Department
ADD manager_start_date DATE;


ALTER TABLE Department
ADD FOREIGN KEY (manager_Ssn) REFERENCES Employee(Ssn);


ALTER TABLE Project
ADD Dnumber int;

ALTER TABLE Project
ADD FOREIGN KEY (Dnumber) REFERENCES Department(DeptNumber);

ALTER TABLE Project
ADD UNIQUE (Pnumber);

ALTER TABLE Works_On
ADD PRIMARY KEY (E_Ssn,P_number);

ALTER TABLE Works_On
ADD FOREIGN KEY (E_Ssn) REFERENCES Employee(Ssn);

ALTER TABLE Works_On
ADD FOREIGN KEY (P_number) REFERENCES Project(Pnumber); 

