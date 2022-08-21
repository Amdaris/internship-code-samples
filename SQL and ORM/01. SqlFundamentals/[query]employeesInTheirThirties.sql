/*How many employees do I have in Romania in their thirties?
Group them by birth year
Count the number of employees in each year
Order them in descending order of the count result*/

SELECT COUNT(ID) as 'Number of employees', BirthYear
FROM dbo.Employees
WHERE Country LIKE 'Romania'
GROUP BY BirthYear
HAVING BirthYear >= 1983 AND BirthYear <= 1992
ORDER BY COUNT(ID) DESC