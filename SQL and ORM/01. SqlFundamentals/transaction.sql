BEGIN TRY
	BEGIN TRANSACTION
		INSERT INTO dbo.Employees (InternalIdentifier, FirstName, LastName, City, Country, BirthYear, NOTES)
			VALUES ('000017', 'Marius', 'Iordate', 'Timisoara', 'Romania', 1998, NULL)
		INSERT INTO dbo.Employees (InternalIdentifier, FirstName, LastName, City, Country, BirthYear, NOTES)
			VALUES ('000018', 'Marius', 'Todor', 'Timisoara', 'Romania', 1920, NULL)
		INSERT INTO dbo.Employees (InternalIdentifier, FirstName, LastName, City, Country, BirthYear, NOTES)
			VALUES ('000019', 'Petru', 'Haheu', 'Chisinau', 'Moldova', 1988, NULL)
	COMMIT TRANSACTION
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH