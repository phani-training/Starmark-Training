--Triggers are like events of SQL. They are sp kind of Stored procedures that are invoked automatically when an insert, delete or update operation happens to a table in the database.
--Triggers are created by the developers to automate a process within the database after a certain action is done by the User. Usually Triggers are used to auto generate backups of the data to central repos, auto deletes after a certain time period. 
--Triggers are like SPs only but U dont call them. It is called implicitly when an action or a condition is met. 
--Triggers are of 3 types: Insertion Triggers, Update Triggers and Delete Triggers. 


Create table tblCustomer
(
CstId int primary key, CstName varchar(50) NOT NULL, CstAddress varchar(200) NOT NULL, BillDate date DEFAULT GetDate(), BillAmount money
)

--------------For auditing purpose to store info when insert, delete or update happens to Customer table. 
Create table Customer_Audit
(
	id int primary key identity(1, 1),
	details varchar(200) NOT NULL
)

---------------------Creating the trigger that triggers on INSERT
Create trigger OnInsertCustomer
ON tblCustomer
FOR INSERT
AS
BEGIN
DECLARE @id int
Select @id = CstId from inserted
Insert into Customer_Audit Values('Customer with ID ' + (CAST(@id as varchar)) + ' is inserted into Database on ' + Cast(GETDATE() as varchar(50)))
END

Insert into tblCustomer values(111, 'TestName','Bangalore', '12/12/2022', 5600)

SELECT * FROM Customer_Audit

----------------------------------DELETE TRIGGER----------------------------------------
Create Trigger OnDeleteCustomer
ON tblCustomer
AFTER DELETE
AS
BEGIN
Declare @id int
Select @id = CstId from deleted
Insert into Customer_Audit Values('Customer with ID ' + (CAST(@id as varchar)) + ' is deleted from Database on ' + Cast(GETDATE() as varchar(50)))
END
Delete from tblCustomer where CstId = 111
---------------------------UPDATE TRIGGER------------------------
Alter Trigger OnUpdateTrigger
ON tblCustomer
After Update
AS
BEGIN
Declare @id int
Declare @oldName varchar(50)
Declare @newName varchar(50)
Select @id = CstId from inserted
SElect @oldName = CstName from deleted
SElect @newName = CstName from inserted
Insert into Customer_Audit Values('Customer with ID ' +  (CAST(@id as varchar)) + ' is updated with ' + @newName + ' replacing the ' + @oldName + ' on ' + cast(GetDate() as varchar))
END

SELECT * FROM tblCustomer
Update tblCustomer Set CstName = 'Gopal' Where CstId = 111

-- Create a SVF to get the total insertions that has happened in the tblCustomer from the Audit table.
Create Function GetInsertionCount() RETURNS INT
AS
BEGIN
RETURN (Select Count(*) From Customer_Audit Where details like '%insert%')
END

Select dbo.GetInsertionCount() as TotalInsertions