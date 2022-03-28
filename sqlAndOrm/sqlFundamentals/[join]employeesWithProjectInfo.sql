/*Get me all the employees including information about the project they are assigned to
 Order by project name */

SELECT e.FirstName, e.LastName, e.Country, p.ProjectName
FROM dbo.Employees as e
INNER JOIN dbo.ProjectEmployees as pe ON e.ID = pe.EmployeeId
INNER JOIN dbo.Projects as p ON p.ID = pe.ProjectId
ORDER BY p.ProjectName