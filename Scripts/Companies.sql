USE LittleCandyShop
GO

CREATE TABLE Companies
(
	Id				INT NOT NULL IDENTITY,
	[Name]			VARCHAR(60) NOT NULL,
	EIN				VARCHAR(9) NOT NULL,
	CityId			INT NOT NULL,
	IsParentCompany	BIT NOT NULL,
	IsActivated		BIT NOT NULL,
	RegisterDate	DATETIME NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (CityId) REFERENCES Cities(Id)
)
go


SET NOCOUNT ON
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop Parent', '584237425', 18875, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '049586723', 18800, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '739612345', 12333, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '284950237', 11894, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '584237425', 9578, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '526745214', 3444, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '648521796', 7935, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '596472103', 9752, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop Parent', '584237425', 18875, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '954721521', 10852, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '945634785', 9333, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '642579431', 7185, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '194528742', 99, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '254854796', 1000, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '195753685', 22, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '212584785', 11, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '248596745', 3584, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '248574158', 9584, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '154785632', 1001, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '548963175', 1148, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '375946855', 1005, 1, 1, GETDATE())
INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
VALUES ('Little Candy Shop', '978613584', 720, 1, 1, GETDATE())


select	*
from	Companies
