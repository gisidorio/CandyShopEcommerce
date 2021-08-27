USE LittleCandyShop
GO

CREATE TABLE CompaniesProducts
(
	CompanyId		INT NOT NULL,
	ProductId		INT NOT NULL,
	StockQuantity	INT NOT NULL,
	PRIMARY KEY(CompanyId, ProductId),
	FOREIGN KEY(CompanyId) REFERENCES Companies(Id),
	FOREIGN KEY(ProductId) REFERENCES Products(Id)
)
GO

SET NOCOUNT ON
INSERT INTO CompaniesProducts (CompanyId, ProductId, StockQuantity) 
VALUES (1, 1, 10000)

INSERT INTO CompaniesProducts (CompanyId, ProductId, StockQuantity) 
VALUES (2, 1, 5000)

INSERT INTO CompaniesProducts (CompanyId, ProductId, StockQuantity) 
VALUES (1, 2, 6000)

SELECT	*
FROM	CompaniesProducts