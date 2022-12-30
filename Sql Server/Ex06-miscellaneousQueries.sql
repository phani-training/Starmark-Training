--------------Distinct clause is used to remove the duplicates from the recordset. Used only with Select statements. 
Select Distinct EmpAddress from tblEmployee

---In clause is used to look among the values from the select. IN statement is equivalent to OR Clause. 
Select * from tblEmployee Where EmpAddress IN ('Bangalore','Hassan', 'Udupi')
Select * from tblEmployee Where EmpAddress NOT IN ('Bangalore','Hassan', 'Udupi')

-----------------Create a table called tblContact that has Name and Address in it. We will use Insert into with select statement. This is the example for bulk insertion 

Create table tblContact(contactId int primary key identity(1,1), contactName varchar(50) NOT NULL, contactCity varchar(200) NOT NULL)

Insert into tblContact(contactName, contactCity) 
Select EmpName, EmpAddress from tblEmployee where EmpId <= 1050
-----------------------Delete using top number or percent-----------------------
Delete top(25) percent from tblEmployee where EmpAddress = 'Mysore'
--We dont have bottom in SQL server.

Delete t1 from tblEmployee t1
Inner join tblEmployee t2 on t1.EmpId = t2.EmpId
Where t2.EmpAddress in (SELECT TOP (25) percent EmpAddress from tblEmployee WHERE EmpAddress = 'Bangalore' ORDER By EmpAddress Desc) 

-------------------------Select on Union Statement-------------------
--Used to combine the results of both the sets and returns unique data from both the sets. If u want both the values, then use UNION ALL. 
Select EmpName from tblEmployee UNION Select tblContact.contactName from tblContact


-------------------------------Pivot table in SQL------------------
-- PIVOT clause in UR Queries will allow to write Cross-Tabulation. U can aggregate UR result sets and rotate rows into columns.

Select 'TotalSalary' As TotalSalariesByDept, [7], [8]
From (select deptId, EmpSalary from tblEmployee) as SourceTable
PIVOT
(
	SUM(EmpSalary) For DeptId in ([7], [8])
)AS PivotTable

