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
SELECT EmpName, Em--- Data Query Language----------------------------
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

SELECT * FROM tblEmployee--- Data Query Language----------------------------
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

SELECT EmpName, DeptId from tblEmployee Where DeptId = (SELECT DeptId from tblEmployee WHERE EmpName = 'Raghunandan'--- Data Query Language----------------------------
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

SELECT * FROM tblEmployee--- Data Query Language----------------------------
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

SELECT * FROM tblEmployee--- Data Query Language----------------------------
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

SELECT * FROM tblEmployee--- Data Query Language----------------------------
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


--------------------------SELECT USING IN CONDTION--------------
SELECT EmpName, EmpAddress FROM tblEmployee WHERE EmpAddress IN ('Bangalore','Mysore','Tumkur')


ALTER TABLE TblEmployee
Add ManagerName varchar(50)

Update tblEmployee
Set ManagerName = (SELECT EmpName From tblEmployee Where ManagerId = EmpId)

SELECT * FROM tblEmployeepAddress FROM tblEmployee WHERE EmpAddress IN ('Bangalore','Mysore','Tumkur')


ALTER TABLE TblEmployee
Add ManagerName varchar(50)

Update tblEmployee
Set ManagerName = (SELECT EmpName From tblEmployee Where ManagerId = EmpId)

SELECT * FROM tblEmployee