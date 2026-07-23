--Part 1 — Database & Table Creation
CREATE DATABASE CompanyDB; 
GO

USE CompanyDB;
GO

--Employee Table Creation
CREATE TABLE Employee(
	Ssn int PRIMARY KEY,
	Fname VARCHAR(50) Not NULL,
	Minit VARCHAR(50) ,
	Lname VARCHAR(50) Not NULL,
	E_Address VARCHAR(50) Not NULL,
	Sex VARCHAR(1) NOT NULL,
	Bdate DATE NOT NULL,
	Salary DECIMAL(10,2) NOT NULL CHECK(Salary>0),
	D_number int NOT NULL,
	supervisor_Ssn int
);


--Department Table Creation
CREATE TABLE Department(
	department_Name VARCHAR(50) Not NULL,
	DeptNumber int PRIMARY KEY,
	NumberOfEmployees int Not NULL CHECK (NumberOfEmployees>0),
	manager_Ssn int NOT NULL UNIQUE,
	manager_start_date DATE NOT NULL
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
	PRIMARY KEY (Pnumber,Plocation),
	Dnumber int NOT NULL
);

--Works_On Table Creation 
CREATE TABLE Works_On(
	E_Ssn int NOT NULL,
	P_number int NOT NULL,
	Works_On_Hours DECIMAL(10,2) NOT NULL CHECK(Works_On_Hours>0),
	PRIMARY KEY (E_Ssn,P_number)
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
ADD FOREIGN KEY (D_number) REFERENCES Department(DeptNumber);


ALTER TABLE Employee
ADD FOREIGN KEY (supervisor_Ssn) REFERENCES Employee(Ssn);




ALTER TABLE Department
ADD FOREIGN KEY (manager_Ssn) REFERENCES Employee(Ssn);


ALTER TABLE Project
ADD FOREIGN KEY (Dnumber) REFERENCES Department(DeptNumber);


ALTER TABLE Works_On
ADD FOREIGN KEY (E_Ssn) REFERENCES Employee(Ssn);

ALTER TABLE Project
ADD UNIQUE (Pnumber);

ALTER TABLE Works_On
ADD FOREIGN KEY (P_number) REFERENCES Project(Pnumber); 


ALTER TABLE Employee
ADD CONSTRAINT CHK_Employee_Sex CHECK (Sex IN ('M','F'));

ALTER TABLE Dependent
ADD CONSTRAINT CHK_Dependent_Sex CHECK (Sex IN ('M','F'));


-- Temporarily disable FK checking
ALTER TABLE Employee NOCHECK CONSTRAINT ALL;
ALTER TABLE Department NOCHECK CONSTRAINT ALL;

-- Department
INSERT INTO Department(department_Name, DeptNumber, NumberOfEmployees, manager_Ssn, manager_start_date)
VALUES ('Computer Science', 1,10,11223344,'2023-11-11');

--Employee
INSERT INTO Employee (Ssn, Fname, Minit, Lname, E_Address, Sex, Bdate, Salary, D_number, supervisor_Ssn)
VALUES (11223344, 'Abdullah','Hilal','Al Shamsi','Oman - Al Buraimi','M','2003-11-22',2000,1,NULL),
(21223344, 'Ali','Abdullah','Al Shamsi','Oman - Muscat','M','2000-3-3',1500,1,11223344);

INSERT INTO Project (Pname, Pnumber, Plocation, Dnumber)
VALUES ('Mobile app', 1,'Muscat',1);

INSERT INTO Works_On (E_Ssn, P_number, Works_On_Hours)
VALUES (11223344, 1,20.5);

INSERT INTO Dependent (E_Ssn, Dependent_name, Sex, Bdate, Relationship)
VALUES (11223344, 'Hilal', 'M', '1975-06-10', 'Father');

-- Re-enable checking and verify the data actually satisfies the constraints
ALTER TABLE Employee WITH CHECK CHECK CONSTRAINT ALL;
ALTER TABLE Department WITH CHECK CHECK CONSTRAINT ALL;

--Update
UPDATE Employee
SET Salary += 50
WHERE Ssn = 11223344;

UPDATE Department
SET NumberOfEmployees +=1
WHERE DeptNumber = 1;

UPDATE Project
SET Plocation = 'Al Buraimi'
WHERE Pnumber = 1;

UPDATE Works_On
SET Works_On_Hours +=3
WHERE P_number=1 AND E_Ssn = 11223344;

UPDATE Employee
SET Salary -= 50
WHERE Ssn = 21223344;

--