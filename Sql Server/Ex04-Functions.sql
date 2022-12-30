--Functions are stored programs that can allow to pass parameters to it and execute it like an Expression. It returns a single value. We call it as SCALAR VALUE Functions(SVFs)
--functions are similar to Procedure in terms of creation and maintainence. 
--But Functions can be used like expressions which with Stored Procs we cant. 

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
SELECT dbo.GetDept(4)


Alter Function CreateDate(@date Date)
RETURNS varchar(20)
AS
BEGIN
DECLARE @retVal varchar(20)
Set @retVal = '' + CAST(DAY(@Date) AS VARCHAR(5)) + '/' + CAST(MONTH(@Date) AS VARCHAR(4)) + '/' + CAST(YEAR(@Date) as varchar(4))
RETURN @retVal
END


Alter Function CreateDate(@date Date)
RETURNS varchar(20)
AS
BEGIN
DECLARE @retVal varchar(20)
Set @retVal = '' + DATENAME(day,@Date) + ' ' + DATENAME(month, @Date)  + ' ' + DATENAME(year, @Date)
RETURN @retVal
END


Create Function GetAge(@dob Date)
RETURNS INT
AS
BEGIN
DECLARE @age int = 0
Set @age = DATEDIFF(year, @dob, GETDATE());
RETURN @age
END


PRINT dbo.GetAge('1976/12/01')

PRINT dbo.CreateDate(GETDATE())


----------------------------Table Value Functions----------------------------------

Create Function GetAllEmployees()
RETURNS TABLE
AS
RETURN(SELECT * FROM tblEmployee)


SELECT EmpName, EmpAddress from dbo.GetAllEmployees()

