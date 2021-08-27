USE LittleCandyShop
GO

CREATE TABLE FAQ
(
		Id				INT NOT NULL IDENTITY,
		Question		VARCHAR(150) NOT NULL,
		Answer			VARCHAR(300) NOT NULL,
		ProductId		INT NOT NULL,
		RegisterDate	DATETIME NOT NULL
		PRIMARY KEY (Id),
		FOREIGN KEY (ProductId)	REFERENCES Products(Id)
)
GO

SET NOCOUNT ON
INSERT INTO FAQ (Question, Answer, ProductId, RegisterDate)
VALUES ('Do you have chocolate filling in the product?', 'Yes, we add chocolate filling to the product.', 6, GETDATE())

SELECT	*
FROM	FAQ

select	*
from	Products