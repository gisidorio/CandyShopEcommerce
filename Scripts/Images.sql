USE LittleCandyShop
GO

CREATE TABLE Images 
(
	Id			INT NOT NULL IDENTITY,
	Directory   VARCHAR(300) NOT NULL,
	Main		BIT NOT NULL,
	ProductId	INT NOT NULL,
	FOREIGN KEY (ProductId) REFERENCES Products(Id)
)
GO

SET NOCOUNT ON
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/morinaga-milk-1.jpg', 1, 11)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/hi-chew-1.jpg', 1, 4)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/kit-kat-1.jpg', 1, 2)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/assorted-zotz-1.jpg', 1, 9)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/glitterati-eleganza-1.jpg', 1, 8)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/cedrinca-espresso-1.jpg', 1, 7)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/pokemon-pez-1.jpg', 1, 6)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/ferrero-roc-1.png', 1, 10)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/mini-mochi-candy-1.jpg', 1, 3)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/muscat-2.jpg', 1, 5)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/muscat.jpg', 0, 5)
INSERT INTO Images (Directory, Main, ProductId) VALUES ('/Content/img/setra-1.jpg', 1, 1)

SELECT	*
FROM Images
