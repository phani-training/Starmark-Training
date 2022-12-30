-- Variables in SQL are prefixed with @
--DECLARE @varName int = 234
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

--------------------Calling the stored Proc-----------------------
DECLARE	@empId int

EXEC	InsertEmployee
		@empName = 'Shivaram',
		@empAddress = 'Udupi',
		@empSalary = 56000,
		@deptId = 1,
		@empId = @empId OUTPUT
		

SELECT	@empId as 'GeneratedEmpId'

-----------------------------Select Employee Proc----------------------------
Create Procedure SelectEmployee
(
 @empId int 
)
AS
SELECT * FROM tblEmployee WHERE EmpId = @empId 

-----------------------------Delete Employee Proc----------------------------
Create Procedure DeleteEmployee(@id int)
AS DELETE From tblEmployee WHERE EmpId = @id

-----------------------------Alter the Procedure------------------------
Alter Procedure DeleteEmployee
@id int, @deptId int
AS
DELETE FROM tblEmployee WHERE EmpId = @id AND DeptId = @deptId
