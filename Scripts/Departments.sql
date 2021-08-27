USE LittleCandyShop
GO

CREATE TABLE Departments
(
	Id				INT NOT NULL IDENTITY,
	[Name]			VARCHAR(50) NOT NULL,	
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY(Id)	
)
GO

SET NOCOUNT ON
INSERT INTO Departments ([Name], RegisterDate) VALUES ('Products/Marketing/Services', GETDATE())
INSERT INTO Departments ([Name], RegisterDate) VALUES ('Sales', GETDATE())
INSERT INTO Departments ([Name], RegisterDate) VALUES ('IT - Information Technology', GETDATE())
INSERT INTO Departments ([Name], RegisterDate) VALUES ('Administrative', GETDATE())

SELECT	*
FROM	Departments
