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
# Transactional Control Language
# Data Query Language
# Data Control Language. 
