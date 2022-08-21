/*Get all projects without any employees assigned */

SELECT p.ProjectName
FROM dbo.Projects as p
WHERE NOT EXISTS(
	SELECT NULL
	FROM dbo.ProjectEmployees as pe
	WHERE pe.ProjectId = p.ID
)