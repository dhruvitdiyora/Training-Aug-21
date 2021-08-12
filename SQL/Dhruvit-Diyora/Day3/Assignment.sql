--task1 - Write a query that displays the FirstName and the length of the FirstName for all employees whose name starts with the letters ‘A’, ‘J’ or ‘M’. Give each column an appropriate label. Sort the results by the employees’ FirstName
SELECT FirstName As "Name",LEN(FirstName) "Length"
FROM Employees WHERE FirstName LIKE 'J%' OR FirstName LIKE 'M%' OR FirstName LIKE 'A%' ORDER BY FirstName ;

--task 2 - Write a query to display the FirstName and Salary for all employees. Format the salary to be 10 characters long, left-padded with the $ symbol. Label the column SALARY.

Select FirstName AS 'First Name',CONCAT(REPLICATE('$', 10-Len(Salary)),Cast(Salary AS varchar)) FROM Employees 

 --task3-Write a query to display the employees with their code, first name, last name and hire date who hired either on seventh day of any month or seventh month in any year.
 select EmployeeID,FirstName,LastName,HireDate from Employees where DATEPART(Day,HireDate)='07' OR DATEPART(Month,HireDate)='07'

 --task4-Write a query to display the length of first name for employees where last name contains character ‘c’ after 2nd position.
  select Len(FirstName) AS 'Length' from Employees where LastName like ('_%c%')

  --task5-Write a query to extract the last 4 character of PhoneNumber.
select RIGHT(PhoneNumber,4) AS 'Phone Number' from Employees

--task6-Write a query to update the portion of the PhoneNumber in the employees table, within the phone number the substring ‘124’ will be replaced by ‘999’.
UPDATE Employees SET PhoneNumber = REPLACE(PhoneNumber, '124', '999') WHERE PhoneNumber LIKE '%124%';

--task7-Write a query to calculate the age in year.
select DATEDIFF(yyyy,'2000-08-31',GetDate())

--task8-Write a query to get the distinct Mondays from HireDate in employees tables.
select EmployeeID,FirstName,LastName,HireDate from Employees where DATENAME(WEEKDAY,HireDate)='Monday'

 --task9-Write a query to get the FirstName and HireDate from Employees table where HireDate between ‘1987-06-01’ and ‘1987-07-30’
 select FirstName,HireDate from Employees where HireDate between '1987-06-01' and '1987-07-30'

--task10- Write a query to display the current date in the following format. Sample output : 12:00 AM Sep 5, 2014
SELECT FORMAT (getdate(), 'hh:mm tt MMM dd, yyyy') as time

--task11-Write a query to get the FirstName, LastName who joined in the month of June.
select FirstName,LastName from Employees where DATENAME(MONTH,HireDate)='June'

--task12-Write a query to get first name, hire date and experience of the employees.
select FirstName AS 'Name',HireDate,CONCAT(DATEDIFF(dd,HireDate,GetDate())/365,' ', 'Year',' ',DATEDIFF(MM,HireDate,GetDate())%12,' ','Month') AS 'Experience' from Employees

--task13-Write a query to get first name of employees who joined in 1987.
select FirstName from Employees where DATEPART(YEAR,HireDate)='1987'

