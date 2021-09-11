USE LittleCandyShop
GO

CREATE TABLE Employees
(
	Id				INT NOT NULL IDENTITY,
	[Name]			VARCHAR(100) NOT NULL,
	SSN				VARCHAR(10) NOT NULL,
	Gender			VARCHAR(6) NOT NULL,
	Salary			NUMERIC(8, 2) NOT NULL,
	CompanyId		INT NOT NULL,
	DepartmentId	INT NOT NULL,
	PositionId		INT NOT NULL,
	IsActivated		BIT NOT NULL,
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (CompanyId) REFERENCES Companies(Id),
	FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
	FOREIGN KEY (PositionId) REFERENCES Positions(Id)
)
GO

SET NOCOUNT ON
INSERT INTO Employees([Name], SSN, Gender, Salary, CompanyId, DepartmentId, PositionId, IsActivated, RegisterDate)
VALUES ('Cedric Greer', 5796438512, 'Male', 50000, 1, 4, 1, 1, GETDATE())


SELECT	*
FROM	Employees