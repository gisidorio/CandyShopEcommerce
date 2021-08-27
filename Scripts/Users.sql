USE LittleCandyShop
GO

CREATE TABLE Users
(
	Id			INT NOT NULL IDENTITY,
	Username	VARCHAR(60) NOT NULL,
	[Password]	VARCHAR(40) NOT NULL,
	ClientId	INT,
	EmployeeId	INT,
	IsActivated BIT NOT NULL,
	RegisterDate DATETIME not null,
	PRIMARY KEY(Id),
	FOREIGN KEY (ClientId) REFERENCES Clients(Id),
	FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
)
GO

SET NOCOUNT ON
INSERT INTO Users (Username, [Password], ClientId, IsActivated, RegisterDate)
VALUES ('supergreatchocolate', 'OQGAmMdnyBmB76jmk/AKA==', 1, 1, GETDATE())
INSERT INTO Users (Username, [Password], EmployeeId, IsActivated, RegisterDate)
VALUES ('ceedricpeace', 'k2wUDGi3wZlZbezh4y1ybQ==', 1, 1, GETDATE())

SELECT	*
FROM	Users