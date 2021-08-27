USE LittleCandyShop
GO

CREATE TABLE Clients
(
	Id				INT NOT NULL IDENTITY,
	Person			VARCHAR(9) NOT NULL,
	[Name]			VARCHAR(60) NOT NULL,
	EIN				VARCHAR(9),
	SSN				VARCHAR(10),
	Gender			VARCHAR(6),
	Email			VARCHAR(100) NOT NULL,
	Phone			VARCHAR(16) NOT NULL,
	IsActivated		BIT NOT NULL,
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY(Id)
)
GO

SET NOCOUNT ON
INSERT INTO Clients (Person, [Name], EIN, Email, Phone, IsActivated, RegisterDate)
VALUES ('Juridical', 'Super Great Chocolate', '468217548', 'bestchocolate@sgchocolate.com', '(415)555-8989', 1, GETDATE())
INSERT INTO Clients (Person, [Name], SSN, Gender, Email, Phone, IsActivated, RegisterDate)
VALUES ('Physical', 'Anna Bertold', '4685731598',  'Female', 'annabertold232@gmail.com', '(202)555-4937', 1, GETDATE())

SELECT	*
FROM	Clients

