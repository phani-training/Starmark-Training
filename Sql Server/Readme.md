# SQL Server
1. SQL Server is a relational database Management Software developed by MS for developing databases to cater the needs of your Software applications.
2. It uses SQL,(Sequel) a Std language for interacting with Databases. It has an improvised version of SQL called as T-SQL developed by MS. 
3. Relational data is something that can be stored in the form of Rows and Columns. These rows and columns are grouped into TABLES. A Database can have multiple tables in it. 
4. Relational data allows the tables to be related to one another in the form of dependencies. 
5. The Success of UR Software is mainly dependent on the Design of the tables in the database.
6. Developers with high level skills on DB Programming can be data analysts and persue a career in Data Analytics, a popular trend in IT. 
7. Sql Server is a Client-Server architecture where the data is stored in a Server environment with a Database Engine. The Client environment would be a Tool like SSMS(SQL Server Management Studio) that will behave like an IDE to work with SQL Server. 
8. SQL Server is available as a network service in ur os. The service is a software that runs on the bootup of UR Machine. It can happen where the server and client can reside in the same machine. We use TCP Bindings to communicate within the network domain of UR Organization. 
9. SQL Server is a Database Manager that has databases to manage its environment. There are 2 parts in SQL Server: Database Engine that performs the data centric operations and processes the queries made to the database. The SQLOs is the Operating System of the database that handles memory and IO related tasks within the SQL server. 
10. SQL Server has a set of databases like Master, Model, TempDB and MSDB for managing the Databases. U create Databases from the Master Database. 
11. SQL Server comes with the following features:
    a. It is a client server architecture. 
    b. It is a database of Databases where the system databases are used to manage the existing user defined databases. 
    c. It allows to perform Transactions within the database. 
    d. It has ACID Properties to maintain Enterprise Database software: Atomicity, Consistancy, Isolation and Durability. 
    e. SQL Server comes with Multi level security at the OS level, Server level, Database level and tables level with multiple roles in UR Databases
12. SQL Code is written as text file saved with extension .sql. 
13. SQL allows to create Predefined functions called Stored Procedures that are optimized to work on the databases. All System Defined Stored Procs are prefixed with sp_

# Data Definition Language.
    - Create Database, Table, Stored Procedure, Function.
    - Drop Database, Table, Stored Procedure, Function.
    - ALTER TABLE is used to modify the table structure. It should be used when U want to add, remove columns, constraints to the table.
    - Alter table should follow with add, drop commands.  
```
Create table tblEmployee
(
  EmpId int PRIMARY KEY IDENTITY(1001, 1),
  EmpName varchar(50) NOT NULL, 
  EmpAddress varchar(MAX) NOT NULL, 
  EmpSalary money NOT NULL 
)
```
Points to remember:
1. Create Table is a Data Definition language code to create new table in the database. 
2. It contains the list of columns that include the Name, data type followed by rules(CONSTRAINTS). 
3. PRIMARY KEY Constraint is used to set a rule to hold only Unique values in that column. A table can have only one Primary key.However U can group one or more columns together to make a Composite Primary key. If U want another column to have unique values, U could use UNIQUE Constraint.  
4. IDENTITY is defined for a column to store auto generating numbers starting with seed and an incremental value.
5. U cannot drop a column that is referenced in another table. In that case, U should drop the relation and then drop the column.


# Data Manipulation Language.
- Insert statement is used to add data to the table. 

```
Insert into tblDept values('Human Resources')
Insert into tblEmployee(EmpName, EmpAddress, DeptId, EmpSalary) VALUES('Mohan Rao', 'Kolar', 3, 56000)
```

- Update Statement is used modify the data in the table based on a condition that is specified in the where clause.

```
Update tblEmployee Set EmpName ='Phani Raj B.N', EmpAddress ='Bengaluru', EmpSalary = 60000 WHERE EmpId = 1001

Update tblEmployee Set DeptId = 2 WHERE EMPID = 1002
```

- Delete Statement is used to remove the rows from a table. 
    - To delete all the rows, U can use TRUNCATE Statement. It is same as DELETE FROM TBLEMPLOYEE without a WHERE Clause.
    - If U want to delete a row which is having a relation with other table data, U should remove the constraint or remove the secondary table data before removing the data in the Primary table. 

```
Delete from tblEmployee where EmpId < 2000
Delete from tblEmployee where DeptId = (SELECT DeptId From tblDept where DeptId < 4)
DELETE FROM tblEmployee WHERE EmpAddress = 'Bangalore' AND EmpId >= 1000

```

# Transactional Control Language
# Data Query Language
- SELECT Statement is used to extract records from the table. 
- Supported by WHERE, ORDER BY, GROUP BY, JOIN Statements. 
- * is a wild char to represent all in the query. 
# Data Control Language.
# Transactional Control Language
# Data Query Language
# Data Control Language. 

```
--- Data Query Language----------------------------
SELECT * FROM tblEmployee

SELECT EmpName, EmpSalary from tblEmployee

--MAX, MIN, TOP, AVG are called as Scalar Value Functions(SVFs) that return only one value from the expression. 
SELECT MAX(EmpSalary) AS MaxSalary, MIN(EmpSalary) as MinSalary, AVG(EmpSalary) as AvgSalary FRom tblEmployee

SELECT EmpName FROM tblEmployee Where EmpAddress = 'Bangalore'

SELECT EmpName From tblEmployee WHERE EmpName LIKE 'A%'

SELECT EmpID, EmpName, DeptId From tblEmployee WHERE DeptId IS NOT NULL

-- Use Coalesce to replace the value based on the truthness of the condition. U can use ISNULL also
SELECT EmpId, EmpName, COALESCE(DeptId, 0) AS DEPTINFO From tblEmployee WHERE DeptId IS NULL

Select  EmpName , ISNULL(DeptId, 0) AS DEPTINFO from tblEmployee 

Select TOP(10) EmpName, tblEmployee.EmpSalary From tblEmployee Where EmpSalary between 30000 and 70000 order by empSalary 

SELECT * FROM tblEmployee WHERE EmpAddress = 'Mysore' OR EmpSalary < 50000

SELECT EmpName, EmpSalary FROM tblEmployee WHERE EmpAddress = 'Mysore' OR EmpAddress = 'Bangalore'


SELECT TOP 50 PERCENT * FROM tblEmployee

--------------------SELECT ORDER BY--------------------------------
SELECT tblEmployee.EmpName FROM tblEmployee ORDER BY EmpName

SELECT tblEmployee.EmpName FROM tblEmployee ORDER BY EmpName DESC

SELECT TOP(5) EmpName From tblEmployee WHERE EmpAddress = 'Bangalore' ORDER BY EmpName

--------------------SELECT JOINS--------------------------------

--Combining 2 table data on common clause is called INNER JOIN
SELECT EMpName, tblDept.DeptName from tblEmployee JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId

------------------LEFT JOIN is all records of the left table and matching records of right table
Select tblEmployee.*, tblDept.DeptName from tblEmployee LEFT JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId

--------------------Right JOIN is opposite of Left Join. 
Select tblEmployee.*, tblDept.DeptName from tblEmployee RIGHT JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId


--get the deptname and max salary of each dept. 
Select tblDept.DeptName, MAX(tblEmployee.EmpSalary) From tblEmployee 
RIGHT JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId
group by tblDept.DeptName
-- get the DeptName and Total Salaries of that dept.
Select tblDept.DeptName, SUM(tblEmployee.EmpSalary) From tblEmployee 
RIGHT JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId
group by tblDept.DeptName
-- Get EmpNames and DeptNames grouped and order by DeptName
Select tblEmployee.EmpName, tblDept.DeptName from tblEmployee 
JOIN tblDept ON tblEmployee.DeptId = tblDept.DeptId
GROUP BY tblEmployee.EmpName, tblDept.DeptName
ORDER BY tblDept.DeptName ASC
-- Get the EmpName, EmpSalary, DeptName on DeptID

--------------Self Join-------------
Alter table tblEmployee
Add ManagerId int 
REFERENCES tblEmployee(EmpId)

Update tblEmployee 
Set ManagerId = 1006 
Where EmpId < 1200 AND EmpId > 1176
SELECT
    employee.EmpId,
        employee.EmpName,
        employee.ManagerId,
        manager.EmpName as ManagerName
FROM tblEmployee employee
JOIN tblEmployee manager
ON employee.ManagerId = manager.EmpId 
SELECT * FROM tblEmployee
DECLARE @id INT = 1004
IF (SELECT TOP(1) EmpID from tblEmployee) > @id
BEGIN
	Update tblEmployee
	set ManagerId = (SELECT (EmpId % 5) + 1 FROM tblEmployee)
END
--------------------SELECT GROUP BY--------------------------------
--Gets the Employees grouped by City
SELECT tblEmployee.EmpAddress, COUNT(EmpName) As EmpCount FROM tblEmployee 
Group by tblEmployee.EmpAddress

SELECT tblEmployee.EmpAddress, AVG(EmpSalary) As AvgSalary FROM tblEmployee 
Group by tblEmployee.EmpAddress

SELECT tblEmployee.EmpName, EmpAddress FROM tblEmployee group by tblEmployee.EmpName, tblEmployee.EmpAddress order by tblEmployee.EmpAddress

select count(empName),empSalary,empAddress from tblEmployee where empSalary<(select max(empSalary) from tblEmployee)group by empAddress, EmpSalary
--When used with groupby, the expression must be either a part of the groupby or an Scalar Value function

Select EmpAddress, SUM(EmpSalary) AS totalSalaries from tblEmployee
group by EmpAddress

---------------update statement for random filling of Dept IDs------------
UPDATE tblEmployee SET DeptId = 7 Where DeptId IS NOT NULL AND EmpId % 2 =  0
SELECT * FROM tblDept

--------------------SELECT GROUP BY AND HAVING--------------------------------
Select EmpAddress, SUM(EmpSalary) AS totalSalaries from tblEmployee
group by EmpAddress
HAVING SUM(EmpSalary) < 200000

--HAVING CHECKS A CONDITION ON GROUPING....
--------------------SUB QUERIES--------------------------------
SELECT EmpName, EmpSalary FROM TBLEMPLOYEE WHERE EMPSALARY > (SELECT AVG(EmpSalary) FROM  tblEmployee)

SELECT EmpName, DeptId from tblEmployee Where DeptId = (SELECT DeptId from tblEmployee WHERE EmpName = 'Raghunandan')


--------------------------SELECT USING IN CONDTION--------------
SELECT EmpName, EmpAddress FROM tblEmployee WHERE EmpAddress IN ('Bangalore','Mysore','Tumkur')


ALTER TABLE TblEmployee
Add ManagerName varchar(50)

Update tblEmployee
Set ManagerName = (SELECT EmpName From tblEmployee Where ManagerId = EmpId)

SELECT * FROM tblEmployee
```
# Stored Procedures
- Stored Procedures are sp statements that are created to execute frequently used queries.
- A procedure is a stored program that you can pass parameters into. It does not return a value like a function does. However, it can return a success/failure status to the procedure that called it.
- Any Query has to go thru' 2 step process: Parsing the Query and Execution of the Query. This will be a performance issue when we use a Query frequently 
- Instead we create a Stored Proc and use it in our Front End Applications.
- With Stored Proc, we can create it once, which will internally parse the SQL statements used in it, and while using the Proc, it does not parse the statements again, there by optimizing the performance of UR Statements execution. 
- Create Procedure is the SQL statement for creating Stored Proc. 
- Procedures can have parameters that can be input(Default) as well as output parameters.
- Output parameters are created as arguments to the procedure but no value will be set, it will be set by the Procedure after the completion of the statements.  
- U can use ALTER and DROP statements on Stored  Procedures. Refer the Example

```
Create Procedure InsertEmployee
(
	@empName varchar(50),
	@empAddress varchar(MAX),
	@empSalary int,
	@deptId int,
	@empId int  OUTPUT
)
AS
INSERT INTO tblEmployee values(@empName, @empAddress, @empSalary, @deptId)
SET @empId = @@IDENTITY
```

# Functions
- Functions are stored programs that can allow to pass parameters to it and execute it like an Expression. It returns a single value. We call it as SCALAR VALUE Functions(SVFs)
- functions are similar to Procedure in terms of creation and maintainence. 
- But Functions can be used like expressions which with Stored Procs we cant. 

```
Create Function GetDept(@id int)
RETURNS varchar(50)
AS
BEGIN
DECLARE @deptName varchar(50)
Set @deptName = (SELECT tblDept.DeptName from tblDept WHERE DeptId = @id)
RETURN @deptName
END
----Call the Function----------------
PRINT dbo.GetDept(4)
```

# Triggers:
- Triggers are like events of SQL. They are sp kind of Stored procedures that are invoked automatically when an insert, delete or update operation happens to a table in the database.
- Triggers are created by the developers to automate a process within the database after a certain action is done by the User. Usually Triggers are used to auto generate backups of the data to central repos, auto deletes after a certain time period. 
- Triggers are like SPs only but U dont call them. It is called implicitly when an action or a condition is met. 
- Triggers are of 3 types: Insertion Triggers, Update Triggers and Delete Triggers. 
