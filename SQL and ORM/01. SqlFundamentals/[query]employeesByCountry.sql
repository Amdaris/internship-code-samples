/*Who are my employees in Romania?*/

SELECT FirstName as 'First name', LastName as 'Last name', City, Country
FROM dbo.Employees
WHERE Country LIKE 'Romania'