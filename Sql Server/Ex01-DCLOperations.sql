sp_databases -- Stored Procedure to get all the databases installed in UR DB instance. 

use [Phaniraj-CSMM40] -- use allows U to select the database in the instance

sp_tables -- stored procedure to get all the tables associated with the current database. 
sp_columns tblEmployee -- stored procedure to get all the collumns of a table associated with the current database. tablename is passed as argument. 

print @@version -- print command is used to print values in the Output window of the SQL SERVER. Variables of SQL server will be prefixed with @. The system variables are prefixed with @@. Examples are @@version that returns the SQL Server version.

-------------------------------Creating tables in the database--------------
Drop table employee-- DROP Command is used to remove a Table from the database. 

Create table tblEmployee
(
  EmpId int PRIMARY KEY IDENTITY(1001, 1),
  EmpName varchar(50) NOT NULL, 
  EmpAddress varchar(MAX) NOT NULL, 
  EmpSalary money NOT NULL 
)

Insert into tblEmployee values('Phaniraj','Bangalore',56000)
Insert into tblEmployee values('Ramesh','Mysore',35000)
Insert into tblEmployee values('Sanjeev','Tumkur',20000)
Insert into tblEmployee values('Ananth','Hosapete',30000)
Insert into tblEmployee values('Aravind','Chitradurga',70000)
Insert into tblEmployee values('Raghunandan','Hubli',55000)
Insert into tblEmployee values('Ravi kumar','Mangalore',50000)


Create table tblDept
(
  DeptId int primary key identity(1,1),
  DeptName varchar(50) NOT NULL
)

-------------------Alter the table to add a new Column that has a reference of the Dept table

ALTER TABLE tblEmployee -- DCL operation to alter the structure of the table
ADD DeptId int NULL -- Add operation will add the Column to the table. 
REFERENCES tblDept(DeptId)


ALTER TABLE tblEmployee
--DROP CONSTRAINT FK__tblEmploy__DeptI__3C69FB99
DROP COLUMN DeptId

Insert into tblDept values('Human Resources')
Insert into tblDept values('Development')
Insert into tblDept values('Transport')
Insert into tblDept values('IT Help Desk')
Insert into tblDept values('Management')
Insert into tblDept values('Utilities')

