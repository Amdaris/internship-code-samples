/*Get all employees that are not assigned to project */

SELECT e.FIrstName, e.LastName, e.Country
FROM dbo.Employees as e
WHERE NOT EXISTS(
	SELECT NULL
	FROM dbo.ProjectEmployees as pe
	WHERE pe.EmployeeId = e.ID
)