INSERT INTO dbo.Employees (InternalIdentifier, FirstName, LastName, City, Country, BirthYear, NOTES)
VALUES
('000001', 'Dan', 'Patrascu-Baba', 'Timisoara', 'Romania', 1984, NULL),
('000002', 'Adina', 'Moldovan', 'Timisoara', 'Romania', 1988, NULL),
('000003', 'Ilia', 'Dermenji', 'Chisinau', 'Moldova', 1990, NULL),
('000004', 'Vesela', 'Topalova', 'Sofia', 'Bulgaria', 1980, NULL),
('000005', 'Constantin', 'Bivol', 'Chisinau', 'Moldova', 2000, NULL),
('000006', 'Vlad', 'Mihet', 'Timisoara', 'Romania', 2002, NULL),
('000008', 'Loredana', 'Filip', 'Timisoara', 'Romania', 1992, NULL),
('000009', 'Sabina', 'Paulesco', 'Chisinau', 'Moldova', 1994, NULL),
('000010', 'Anna', 'Grier', 'Timisoara', 'Romania', 1990, NULL),
('000011', 'Pavel', 'Martiniuc', 'Chisinau', 'Moldova', 1994, NULL),
('000012', 'Sergiu', 'Stipanov', 'Chisinau', 'Moldova', 1994, NULL),
('000013', 'Tatiana', 'Adomnita', 'Chisinau', 'Moldova', 1990, NULL),
('000014', 'Ion', 'Gandrabura', 'Chisinau', 'Moldova', 1988, NULL),
('000015', 'Adrian', 'Marinescu', 'Timisoara', 'Romania', 1988, NULL)

INSERT INTO dbo.Projects (ProjectName, ProjectDescription, CustomerName, Revenue)
VALUES
('ProjectPlan', NULL, 'Amdaris', 0),
('Project Tango', NULL, 'Microsoft', 1150489/78),
('Hello world', NULL, 'Oracle', 159753.45),
('Meta', NULL, 'Meta Corporation', 78456.65)

INSERT INTO dbo.ProjectEmployees (ProjectId, EmployeeId)
VALUES
(1, 8),
(1, 5),
(1, 2),
(2, 13),
(3, 1),
(3, 7),
(3, 6),
(3, 4)