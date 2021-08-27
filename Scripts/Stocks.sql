USE LittleCandyShop
GO

CREATE TABLE Stocks
(
	Id					INT NOT NULL IDENTITY,
	ProductName			VARCHAR(70) NOT NULL,
	[Description]		TEXT,
	UnitPurchasePrice	NUMERIC(8, 2) NOT NULL,
	UnitSalePrice		NUMERIC(8, 2) NOT NULL,
	IsActivated			BIT NOT NULL,
	RegisterDate		DATETIME NOT NULL,
	PRIMARY KEY(Id)
)
GO

SET NOCOUNT ON
INSERT INTO Stocks (ProductName, [Description], UnitPurchasePrice, UnitSalePrice, IsActivated, RegisterDate)
VALUES ('Pink Heart Chocolate Box', 'Your dream in a pink heart box full of chocolate', 51.47, 62.12, 1, GETDATE())

SELECT	*
FROM	Stocks