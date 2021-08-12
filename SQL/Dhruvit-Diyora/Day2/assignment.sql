--update queries
--task1-Write a SQL statement to change the Email column of Employees table with ‘not available’ for all employees.

alter table Employees DROP CONSTRAINT ukEmail

update Employees set Email='not available'

alter table Employees ADD CONSTRAINT ukEmail UNIQUE (Email)
--task2-Write a SQL statement to change the Email and CommissionPct column of employees table with ‘not available’ and 0.10 for all employees.

update Employees set Email='not available', CommissionPct=0.10

--task3-Write a SQL statement to change the Email and CommissionPct column of employees table with ‘not available’ and 0.10 for those employees whose DepartmentID is 110.

update Employees set Email='not available', CommissionPct=0.10 where DepartmentID=110;

--task4-Write a SQL statement to change the Email column of employees table with ‘not available’ for those employees whose DepartmentID is 80 and gets a commission is less than 20%

update Employees set Email='not available' where DepartmentID=80 AND CommissionPct<0.20

--task5-Write a SQL statement to change the Email column of employees table with ‘not available’ for those employees who belongs to the ‘Accouning’ department.

update Employees set Email='not available' from Employees E join Departments D on D.DepartmentID=E.DepartmentID where D.DepartmentName='Accounting'

--task6-Write a SQL statement to change salary of employee to 8000 whose ID is 105, if the existing salary is less than 5000.

update Employees set Salary = CASE WHEN salary<5000 then 8000 ELSE Salary END WHERE EmployeeID=105

--task7-Write a SQL statement to change job ID of employee which ID is 118, to SH_CLERK if the employee belongs to department, which ID is 30 and the existing job ID does not start with SH.

update Employees set JobId='SH_CLERK' where EmployeeID=118 AND DepartmentID=30 AND JobId!='SH%'

--task8-Write a SQL statement to increase the salary of employees under the department 40, 90 and 110 according to the company rules that, salary will be increased by 25% for the department 40, 15% for department 90 and 10% for the department 110 and the rest of the departments will remain same.

update Employees 
	set Salary = 
		case 
		when DepartmentID=40 
			then Salary+((0.25*Salary))
		when DepartmentID=90
			then (Salary+(0.15*Salary))
		when DepartmentID=110
			then (Salary+(0.10*Salary))
		ELSE 
			Salary
		end

--task9-·         Write a SQL statement to increase the minimum and maximum salary of PU_CLERK by 2000 as well as the salary for those employees by 20% and commission by 10% .



--basic select queries
--task1-Get all employee details from the Employee table

select * from Employees

--task2-Get FirstName, LastName from Employees table

select FirstName,LastName from Employees

--task3-Get FirstName from Employees table using alias name “Employee Name”

select FirstName AS 'Employee Name' from Employees

--task4-Get employee details from Employees table whose Employee Name is “Steven”

select * from Employees where FirstName='Steven'

--task5-Get employee details from Employees table whose Employee Name are “Neena” and “Lex”

select * from Employees where FirstName='Neena' OR FirstName='Lex'

--task6-Get employee details from Employees table whose Employee name are not “Neena” and “Neena”

select * from Employees where FirstName!='Neena' OR FirstName!='Nina'

--task7-Get employee details from Employees table whose Salary between 5000 and 8000

select * from Employees where Salary BETWEEN 5000 AND 8000

--task8-Write a query to get the names (FirstName, LastName), Salary, PF of all the Employees (PF is calculated as 12% of salary).

select CONCAT(FirstName,' ', LastName) AS names,Salary,(Salary*0.12) AS 'PF' from Employees

--task9-Get employee details from Employees table whose FirstName starts with ‘N’

select * from Employees where FirstName LIKE 'N%'

--task10-Write a query to get unique department ID from Employees table

SELECT DISTINCT DepartmentID FROM employees;

--task11-Write a query to get unique department ID from Employees table

select * from Employees Order By FirstName DESC

--task12-Write a query to get the EmployeeID, names (FirstName, LastName), salary in ascending order of salary.

select EmployeeID,  CONCAT(FirstName,' ', LastName) AS names, Salary from Employees Order By Salary ASC

--task13-Select TOP 2 salary from employee table

SELECT TOP 2 Salary from Employees 
