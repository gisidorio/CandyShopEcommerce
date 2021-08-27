USE LittleCandyShop
GO


CREATE TABLE Orders
(
	Id				BIGINT NOT NULL IDENTITY,
	TotalPrice		DECIMAL NOT NULL,
	ClientId		INT NOT NULL,
	PaymentId		INT NOT NULL,
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (ClientId) REFERENCES Clients(Id),
	FOREIGN KEY (PaymentId) REFERENCES Payments(Id)
)


