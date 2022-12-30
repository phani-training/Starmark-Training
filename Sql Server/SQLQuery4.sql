DECLARE @No INT = 6;
IF @No = 5
	SELECT TOP(@No)  EmpSalary FROM tblEmployee ORDER BY EmpSalary  DESC
ELSE
	SELECT TOP(10) tblEmployee.EmpSalary from tblEmployee ORDER BY EmpSalary DESC