USE LittleCandyShop
GO

CREATE TABLE Payments
(
	Id				INT NOT NULL IDENTITY,
	Method			VARCHAR(40) NOT NULL,
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY (Id)
)
GO

SET NOCOUNT ON
INSERT INTO Payments (Method, RegisterDate) VALUES ('Credit Card', GETDATE())
INSERT INTO Payments (Method, RegisterDate) VALUES ('Debit Card', GETDATE())

SELECT	*
FROM	Payments