--task-1-Create a batch Select Banking as ‘Bank Dept’, Insurance as ‘Insurance Dept’ and Services as ‘Services Dept’ from employee table
SELECT *,
    CASE
        WHEN Department='Banking' THEN 'Bank Dept'
        WHEN Department='Insurance' THEN 'Insurance Dept'
        WHEN Department='Services' THEN 'Services Dept'
        ELSE Department
    END AS Department
    FROM Employee
GO

--task-2- 5 Students Name, Address, City, DOB, Standard need to be inserted in the student table, need to fetch these result from json variable. and select output in the json format
