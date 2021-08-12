
--pract1-Write a SQL statement to create a table named countries including columns CountryId, CountryName and RegionId and make sure that no countries except Italy, India and China will be entered in the table. and combination of columns CountryId and RegionId will be unique.
CREATE TABLE countries (
COUNTRY_ID varchar(10) NOT NULL UNIQUE DEFAULT '',
COUNTRY_NAME varchar(40) UNIQUE NULL CHECK(COUNTRY_NAME IN('Italy','India','China')) ,
REGION_ID varchar(2) UNIQUE NOT NULL,
PRIMARY KEY (COUNTRY_ID,REGION_ID));
--pract2-Write a SQL statement to create a table named JobHistory including columns EmployeeId, StartDate, End_Eate, Job_Id and Department_Id and make sure that the value against column EndDate will be entered at the time of insertion to the format like ‘–/–/—-‘.
create table JobHistory(
EmployeeID INT PRIMARY KEY Identity(1,1),
StartDate Date Not null,
EndDate Date not null,
CONSTRAINT CHK_Person check (EndDate Like '--/--/----'),
JobID int not null,
DepartmentId int
);
insert into JobHistory values ('2021-02-08','08-05-2021',2,4);

drop table JobHistory;

--task3-Write a SQL statement to create a table named jobs including columns JobId, JobTitle, MinSalary and MaxSalary, and make sure that, the default value for JobTitle is blank and MinSalary is 8000 and MaxSalary is NULL will be entered automatically at the time of insertion if no value assigned for the specified columns.
CREATE TABLE jobs( 
JOB_ID INT PRIMARY KEY Identity(1,1), 
JOB_TITLE varchar(35) DEFAULT ' ', 
MIN_SALARY decimal(6,0) DEFAULT 8000, 
MAX_SALARY decimal(6,0) DEFAULT NULL
);
drop table jobs
insert into jobs (MIN_SALARY,MAX_SALARY) values ('nathi kevu',1000,2000),('kone kh',500,1000)
select * from jobs

--task4-Write a SQL statement to create a table employees including columns Employee_Id, FirstName, LastName, Email, PhoneNumber, Hire_Date, Job_Id, Salary, Commission, Manager_Id and Department_Id and make sure that, the Employee_Id column does not contain any duplicate value at the time of insertion, and the foreign key column DepartmentId, reference by the column DepartmentId of Departments table, can contain only those values which are exists in the Department table and another foreign key column JobId, referenced by the column JobId of jobs table, can contain only those values which are exists in the jobs table.
CREATE TABLE employees ( EmployeeID INT PRIMARY KEY Identity(1,1), 
FIRST_NAME varchar(20) not NULL, 
LAST_NAME varchar(25) NOT NULL, 
EMAIL varchar(25) NOT NULL, 
PHONE_NUMBER varchar(20) not NULL, 
HIRE_DATE date NOT NULL, 
JOB_ID int NOT NULL, 
SALARY decimal(8,2) not NULL,
COMMISSION_PER decimal(5,2) not NULL,
MANAGER_ID int not NULL, 
DEPARTMENT_ID int not null, 


CONSTRAINT FK_DEPARTMENT_ID FOREIGN KEY (DEPARTMENT_ID) REFERENCES departments(DEPARTMENT_ID),
CONSTRAINT FK_JOB_ID FOREIGN KEY (JOB_ID) REFERENCES jobs(JOB_ID)
);

CREATE TABLE departments ( DEPARTMENT_ID INT PRIMARY KEY Identity(1,1));