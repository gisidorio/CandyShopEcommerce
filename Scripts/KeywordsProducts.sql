USE LittleCandyShop
GO

CREATE TABLE KeywordsProducts
(
	KeywordId			INT NOT NULL,
	ProductId			INT NOT NULL,
	PRIMARY KEY (KeywordId, ProductId),
	FOREIGN KEY (KeywordId) REFERENCES Keywords(Id),
	FOREIGN KEY (ProductId) REFERENCES Products(Id)
)
GO

set nocount on
INSERT INTO KeywordsProducts (KeywordId, ProductId)
VALUES (1, 2)
INSERT INTO KeywordsProducts (KeywordId, ProductId)
VALUES (1, 1)
INSERT INTO KeywordsProducts (KeywordId, ProductId)
VALUES (2, 3)
INSERT INTO KeywordsProducts (KeywordId, ProductId)
VALUES (3, 11)

SELECT	keywprod.KeywordId,
		keywprod.ProductId,
		keyw.Word,
		prod.[Name]
FROM	KeywordsProducts AS keywprod
JOIN	Keywords AS keyw
ON		keywprod.KeywordId = keyw.Id
JOIN	Products AS prod
ON		keywprod.ProductId = prod.Id