# SQL SELECT query exercies

Note: This exercise is based on the HR database. 

Before you begin, 

* Download the script file HR.sql 
* Execute the Script in the SQL server Database. 

## Exercise questions

1. Write a query to display the lastname, department number, and department name for all employees.
1. Create a unique listing of all jobs that are in department 30. Include the location id in the output.
1. Write a query to display the employee lastname, department name, location id, and city of all employees who earn a commission.
1. Display the employee lastname, and department name for all employees who have an "a" in their lastname.
1. Write a query to display the lastname, job, department number, and department name for all employees who work in Toronto.
1. Display the employee lastname and employee number along with their manager's lastname and manager number. Label the columns "Employee", "Emp#", "Manager" and "Manager#" respectively.
1. Modify the above to display the same columns for all employees (including "King", who has no manager). Order the result by the employee number.
1. Create query that displays employee lastnames, department numbers, and all the employees who work in the same department as a given employee. Give each column an appropriate label.
1. Create a query that displays the name, job, department name, salary and grade for all employees.
1. Create a query to display the name and hiredate of any employee hired after employee "Davies"
1. Display the names and hire dates for all employees who were hired before their managers, along with their manager's names and hiredates. Label the columns "Employee", "Emp hired", "Manager", and "Manager hired" respectively.
1. Display the highest, lowest, sum and average salary of all employees. Label the columns "Maximum", "Minimum", "Sum", and "Average" respectively.
1. Modify the above query to display the same data for each job type.
1. Write a query to display the number of people with the same job.
1. Determine the number of managers without listing them. Label the column "Number of Managers". [Hint: use the MANAGER_ID column to determine the number of managers]
1. Write a query that displays the difference between the highest and the lowes salaries. Label the column as "Difference".
1. Display the manager number and the salary of the lowest paid employee for that manager. Exclude anyone whose manager is not known. Exclude any group where the minimum salary is less than $6000. Sort the output in descending order of salary.
1. Write a query to display each department's name, location, number of employees, and the average salary for all employees in that department. Label the columns "Name", "Location", "No.of people", and "SAlary" respectively. Round the average salary to two decimal places.
1. Write a query to display the lastname, and hiredate of any employee in the department as the employee "Zlotkey". Exclude "Zlotkey".
1. Create a query to display the employee numbers and lastnames of all employees who earn more than the average salary. Sort the result in ascending order of salary.
1. Write a query that displays the employee number and lastname of all employees who work in a department with any employee whose lastname contains a "u".
1. Display the lastname, department number, and job id of all employees whose department location id is 1700.
1. Display the lastname and salary of every employee who reports to "King".
1. Display the department number, lastname, and job id for every employee in the "Executive" department.
1. Display the employee number, lastname, and salary of all employees who earn more than the average salary and who work in a department with any employee with a "u" in their lastname.
1. Write a query to get unique department ID from employee table.
1. Write a query to get all employee details from the employee table order by first name, descending.
1. Write a query to get the names (first_name, last_name), salary, PF of all the employees (PF is calculated as 15% of salary).
1. Write a query to get the employee ID, names (first_name, last_name), salary in ascending order of salary.
1. Write a query to get the total salaries payable to employees.
1. Write a query to get the maximum and minimum salary from employees table. 
1. Write a query to get the average salary and number of employees in the employees table.
1. Write a query to get the number of employees working with the company.
1. Write a query to get the number of jobs available in the employees table.
1. Write a query get all first name from employees table in upper case.
1. Write a query to get the first 3 characters of first name from employees table.
1. Write a query to get the names (for example Ellen Abel, Sundar Ande etc.) of all the employees from employees table.
1. Write a query to get first name from employees table after removing white spaces from both side.
1. Write a query to get the length of the employee names (first_name, last_name) from employees table.
1. Write a query to check if the first_name fields of the employees table contains numbers. 
1. Write a query to select first 10 records from a table.
1. Write a query to get monthly salary (round 2 decimal places) of each and every employee.
1. Write a query to display the name (first_name, last_name) and salary for all employees whose salary is not in the range $10,000 through $15,000.
1. Write a query to display the name (first_name, last_name) and department ID of all employees in departments 30 or 100 in ascending order.
1. Write a query to display the name (first_name, last_name) and salary for all employees whose salary is not in the range $10,000 through $15,000 and are in department 30 or 100. 
1. Write a query to display the name (first_name, last_name) and hire date for all employees who were hired in 1987.
1. Write a query to display the first_name of all employees who have both "b" and "c" in their first name.
1. Write a query to display the last name, job, and salary for all employees whose job is that of a Programmer or a Shipping Clerk, and whose salary is not equal to $4,500, $10,000, or $15,000.
1. Write a query to display the last name of employees whose names have exactly 6 characters.
1. Write a query to display the last name of employees having 'e' as the third character.
1. Write a query to display the jobs/designations available in the employees table.
1. Write a query to display the name (first_name, last_name), salary and PF (15% of salary) of all employees.
1. Write a query to select all record from employees where last name in 'BLAKE', 'SCOTT', 'KING' and 'FORD'.
1. Write a query to list the number of jobs available in the employees table.
1. Write a query to get the total salaries payable to employees.
1. Write a query to get the minimum salary from employees table.
1. Write a query to get the maximum salary of an employee working as a Programmer.
1. Write a query to get the average salary and number of employees working the department 90.
1. Write a query to get the highest, lowest, sum, and average salary of all employees.
1. Write a query to get the number of employees with the same job.
1. Write a query to get the difference between the highest and lowest salaries. 
1. Write a query to find the manager ID and the salary of the lowest-paid employee for that manager.
1. Write a query to get the department ID and the total salary payable in each department. 
1. Write a query to get the average salary for each job ID excluding programmer. 
1. Write a query to get the total salary, maximum, minimum, average salary of employees (job ID wise), for department ID 90 only.
1. Write a query to get the job ID and maximum salary of the employees where maximum salary is greater than or equal to $4000.
1. Write a query to get the average salary for all departments employing more than 10 employees.
1. Write a query to find the name (first_name, last_name) and the salary of the employees who have a higher salary than the employee whose last_name='Bull'.
1. Write a query to find the name (first_name, last_name) of all employees who works in the IT department.
1. Write a query to find the name (first_name, last_name) of the employees who have a manager and worked in a USA based department. (Hint : Write single-row and multiple-row subqueries)
1. Write a query to find the name (first_name, last_name) of the employees who are managers.
1. Write a query to find the name (first_name, last_name), and salary of the employees whose salary is greater than the average salary.
1. Write a query to find the name (first_name, last_name), and salary of the employees whose salary is equal to the minimum salary for their job grade.
1. Write a query to find the name (first_name, last_name), and salary of the employees who earns more than the average salary and works in any of the IT departments.
1. Write a query to find the name (first_name, last_name), and salary of the employees who earns more than the earning of Mr. Bell.
1. Write a query to find the name (first_name, last_name), and salary of the employees who earn the same salary as the minimum salary for all departments.
1. Write a query to find the name (first_name, last_name), and salary of the employees whose salary is greater than the average salary of all departments. 
1. Write a query to find the name (first_name, last_name) and salary of the employees who earn a salary that is higher than the salary of all the Shipping Clerk (JOB_ID = 'SH_CLERK'). Sort the results of the salary of the lowest to highest.
1. Write a query to find the name (first_name, last_name) of the employees who are not supervisors. 
1. Write a query to display the employee ID, first name, last name, and department names of all employees. 
1. Write a query to display the employee ID, first name, last name, salary of all employees whose salary is above average for their departments. 
1. Write a query to fetch even numbered records from employees table.
1. Write a query to find the 5th maximum salary in the employees table. 
1. Write a query to find the 4th minimum salary in the employees table.
1. Write a query to select last 10 records from a table. 
1. Write a query to list the department ID and name of all the departments where no employee is working. 
1. Write a query to get 3 maximum salaries. 
1. Write a query to get 3 minimum salaries.
1. Write a query to get nth max salaries of employees. 
1. Write a query to find the addresses (location_id, street_address, city, state_province, country_name) of all the departments.
1. Write a query to find the name (first_name, last name), department ID and name of all the employees.
1. Write a query to find the name (first_name, last_name), job, department ID and name of the employees who works in London. 
1. Write a query to find the employee id, name (last_name) along with their manager_id and name (last_name). 
1. Write a query to find the name (first_name, last_name) and hire date of the employees who was hired after 'Jones'.
1. Write a query to get the department name and number of employees in the department.
1. Write a query to find the employee ID, job title, number of days between ending date and starting date for all jobs in department 90.
1. Write a query to display the department ID and name and first name of manager.
1. Write a query to display the department name, manager name, and city. 
1. Write a query to display the job title and average salary of employees.
1. Write a query to display job title, employee name, and the difference between salary of the employee and minimum salary for the job.
1. Write a query to display the job history that were done by any employee who is currently drawing more than 10000 of salary.
1. Write a query to display department name, name (first_name, last_name), hire date, salary of the manager for all managers whose experience is more than 15 years. 
1. Write a query to get the first name and hire date from employees table where hire date between '1987-06-01' and '1987-07-30'
1. Write a query to get the firstname, lastname who joined in the month of June.
1. Write a query to get the years in which more than 10 employees joined.
1. Write a query to get first name of employees who joined in 1987. 
1. Write a query to get department name, manager name, and salary of the manager for all managers whose experience is more than 5 years.
1. Write a query to get employee ID, last name, and date of first salary of the employees. 
1. Write a query to get first name, hire date and experience of the employees. 
1. Write a query to get the department ID, year, and number of employees joined. 
1. Write a query to get the job_id and related employee's id. 


Partial output of the query:


| job_id     	| Employees ID            	|
|------------	|-------------------------	|
| AC_ACCOUNT 	| 206                     	|
| AC_MGR     	| 205                     	|
| AD_ASST    	| 200                     	|
| AD_PRES    	| 100                     	|
| AD_VP      	| 101 ,102                	|
| FI_ACCOUNT 	| 110 ,113 ,111 ,109 ,112 	|



112. Write a query to update the portion of the phone_number in the employees table, within the phone number the substring '124' will be replaced by '999'.
1. Write a query to get the details of the employees where the length of the first name greater than or equal to 8.
1. Write a query to display leading zeros before maximum and minimum salary.
1. Write a query to append '@example.com' to email field.
1. Write a query to get the employee id, first name and hire month.
1. Write a query to get the employee id, email id (discard the last three characters). 
1. Write a query to find all employees where first names are in upper case.
1. Write a query to extract the last 4 character of phone numbers. 
1. Write a query to get the last word of the street address. 
1. Write a query to get the locations that have minimum street length.
1. Write a query to display the first word from those job titles which contains more than one words.
1. Write a query to display the length of first name for employees where last name contain character 'c' after 2nd position.
1. Write a query that displays the first name and the length of the first name for all employees whose name starts with the letters 'A', 'J' or 'M'. Give each column an appropriate label. Sort the results by the employees' first names.
1. Write a query to display the first name and salary for all employees. Format the salary to be 10 characters long, left-padded with the $ symbol. Label the column SALARY. 
1. Write a query to display the first eight characters of the employees' first names and indicates the amounts of their salaries with '$' sign. Each '$' sign signifies a thousand dollars. Sort the data in descending order of salary. 
1. Write a query to display the employees with their code, first name, last name and hire date who hired either on seventh day of any month or seventh month in any year. 