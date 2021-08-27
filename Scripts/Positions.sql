USE LittleCandyShop
GO

CREATE TABLE Positions
(
	Id				INT NOT NULL IDENTITY,
	[Name]			VARCHAR(50) NOT NULL,	
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY(Id)	
)
GO

SET NOCOUNT ON
INSERT INTO Positions ([Name], RegisterDate) VALUES ('Director', GETDATE())
INSERT INTO Positions ([Name], RegisterDate) VALUES ('Global Manager', GETDATE())
INSERT INTO Positions ([Name], RegisterDate) VALUES ('Regional Manager', GETDATE())
INSERT INTO Positions ([Name], RegisterDate) VALUES ('Distrital Manager', GETDATE())



