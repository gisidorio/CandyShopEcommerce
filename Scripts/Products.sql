USE LittleCandyShop
GO

CREATE TABLE Products
(
	Id				INT NOT NULL IDENTITY,
	[Name]			VARCHAR(70) NOT NULL,
	[Description]	TEXT,
	PurchasePrice	NUMERIC(8, 2) NOT NULL,
	SalePrice		NUMERIC(8, 2) NOT NULL,
	IsActivated		BIT NOT NULL,
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY(Id)
)
GO

SET NOCOUNT ON
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Chocolate Milk Ultra setra', 'Good chocolate milk for every one!', 10.56, 12.32, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Kit Kat', 'The insane Nestle chocolate', 3.19, 3.51, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Mini Mochi Candy', 'Little Mochi Candy', 3.22, 3.50, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Hi-Chew Fruit Chews 10-Piece Candy Packs - Kiwi: 15-Piece Box', 'Fruit Chews', 14.55, 15.51, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Kasugai Muscat White Grape Gummy Candy: 20-Piece Bag', '', 3.19, 5.13, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Pokemon PEZ Dispenser Candy Packs: 12-Piece Set', 'Pikachu!', 16.33, 19.38, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Cedrinca Espresso Hard Candy: 4.25-Ounce Bag', '', 3.19, 4.93, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Glitterati Candy - Eleganza: 750-Piece Bag', '', 27.00, 29.45, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Assorted Zotz Sour Fizz Candy: 300-Piece Tub', '', 43.99, 45.00, 1, GETDATE())
INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate) 
VALUES ('Ferrero Rocher Chocolate Balls: 48-Piece Box', '', 22.00, 24.00, 1, GETDATE())


SELECT	*
FROM	Products