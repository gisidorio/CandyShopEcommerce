USE LittleCandyShop
GO

CREATE TABLE Keywords
(
		Id				INT NOT NULL IDENTITY,
		Word			VARCHAR(50) NOT NULL,
		RegisterDate	DATETIME NOT NULL,
		PRIMARY KEY (Id)
)
GO

SET NOCOUNT ON
INSERT INTO Keywords (Word, RegisterDate) VALUES ('Chocolates', GETDATE())
INSERT INTO Keywords (Word, RegisterDate) VALUES ('Mochi', GETDATE())
INSERT INTO Keywords (Word, RegisterDate) VALUES ('Morinaga', GETDATE())

select	*
from	Keywords