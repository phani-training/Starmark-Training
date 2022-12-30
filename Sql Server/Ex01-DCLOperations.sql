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
  EmpSalary money NOT NULL,
  DeptId int references tblDept(DeptId)
)

Insert into tblEmployee values('Phaniraj','Bangalore',56000, 2)
Insert into tblEmployee values('Ramesh','Mysore',35000,2)
Insert into tblEmployee values('Sanjeev','Tumkur',20000, 3)
Insert into tblEmployee values('Ananth','Hosapete',30000,4)
Insert into tblEmployee values('Aravind','Chitradurga',70000,2)
Insert into tblEmployee values('Raghunandan','Hubli',55000, 1)
Insert into tblEmployee values('Ravi kumar','Mangalore',50000, 1)


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

------------------Update Statement------------------
-- Update tablename set colName = value.... where colName = value;
Update tblEmployee Set EmpName ='Phani Raj B.N', EmpAddress ='Bengaluru', EmpSalary = 60000 WHERE EmpId = 1001

Update tblEmployee Set DeptId = 2 WHERE EMPID = 1002

-------------------Delete Statement-------------------------------------
DELETE FROM TBLEMPLOYEE WHERE EMPID < 2000

-- To delete all the rows, U can use TRUNCATE Statement. It is same as DELETE FROM TBLEMPLOYEE without a WHERE Clause

SELECT * FROM TBLEMPLOYEE
TRUNCATE TABLE tblDept
SELECT * FROM TBLEMPLOYEE WHERE DeptId IS NOT NULL

DELETE FROM TBLDEPT WHERE DeptId = 2
UPDATE tblEmployee SET DeptId = NULL WHERE DEPTID = 2
SELECT COUNT(*) FRom TBLEMPLOYEE

SELECT * FROM TBLDEPT
CREATE TABLE tblCity(
   CityId int primary key identity(1,1),
   City VARCHAR(30) NOT NULL
);
INSERT INTO tblCity(City) VALUES ('Qingdao');
INSERT INTO tblCity(City) VALUES ('Tokyo');
INSERT INTO tblCity(City) VALUES ('Ho Chi Minh City');
INSERT INTO tblCity(City) VALUES ('New York City');
INSERT INTO tblCity(City) VALUES ('Shenyang');
INSERT INTO tblCity(City) VALUES ('Atlanta');
INSERT INTO tblCity(City) VALUES ('Mumbai');
INSERT INTO tblCity(City) VALUES ('Brussels');
INSERT INTO tblCity(City) VALUES ('Nizhny Novgorod');
INSERT INTO tblCity(City) VALUES ('Munich');
INSERT INTO tblCity(City) VALUES ('Budapest');
INSERT INTO tblCity(City) VALUES ('Singapore');
INSERT INTO tblCity(City) VALUES ('Bogotá');
INSERT INTO tblCity(City) VALUES ('Kuala Lumpur');
INSERT INTO tblCity(City) VALUES ('Harbin');
INSERT INTO tblCity(City) VALUES ('Bangalore');
INSERT INTO tblCity(City) VALUES ('Karachi');
INSERT INTO tblCity(City) VALUES ('Birmingham');
INSERT INTO tblCity(City) VALUES ('Chengdu');
INSERT INTO tblCity(City) VALUES ('Beijing');
INSERT INTO tblCity(City) VALUES ('Lahore');
INSERT INTO tblCity(City) VALUES ('Perm');
INSERT INTO tblCity(City) VALUES ('London');
INSERT INTO tblCity(City) VALUES ('Hamburg');
INSERT INTO tblCity(City) VALUES ('Hangzhou');
INSERT INTO tblCity(City) VALUES ('Dongguan');
INSERT INTO tblCity(City) VALUES ('Kyiv');
INSERT INTO tblCity(City) VALUES ('Odessa');
INSERT INTO tblCity(City) VALUES ('Guangzhou');
INSERT INTO tblCity(City) VALUES ('Madrid');
INSERT INTO tblCity(City) VALUES ('Barcelona');
INSERT INTO tblCity(City) VALUES ('Pune');
INSERT INTO tblCity(City) VALUES ('Jinan');
INSERT INTO tblCity(City) VALUES ('Prague');
INSERT INTO tblCity(City) VALUES ('Suzhou');
INSERT INTO tblCity(City) VALUES ('Buenos Aires');
INSERT INTO tblCity(City) VALUES ('Santiago');
INSERT INTO tblCity(City) VALUES ('Miami');
INSERT INTO tblCity(City) VALUES ('Guadalajara');
INSERT INTO tblCity(City) VALUES ('Milan');
INSERT INTO tblCity(City) VALUES ('Hyderabad');
INSERT INTO tblCity(City) VALUES ('Volgograd');
INSERT INTO tblCity(City) VALUES ('Riyadh');
INSERT INTO tblCity(City) VALUES ('Lima');
INSERT INTO tblCity(City) VALUES ('Rio de Janeiro');
INSERT INTO tblCity(City) VALUES ('Nanjing');
INSERT INTO tblCity(City) VALUES ('Cologne');
INSERT INTO tblCity(City) VALUES ('Tehran');
INSERT INTO tblCity(City) VALUES ('Seoul');
INSERT INTO tblCity(City) VALUES ('Shanghai');

Update tblEmployee 
SET EmpAddress = (SELECT City From tblCity Where CityId % 1 = 0)
Where EmpId % 1 = 0;