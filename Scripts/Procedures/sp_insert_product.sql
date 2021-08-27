USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_product')
BEGIN 
	DROP PROCEDURE sp_insert_product
	PRINT '<<< PROCEDURE sp_insert_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_product
(	
	@Name					VARCHAR(70) = NULL,
	@Description			TEXT = NULL,
	@PurchasePrice			NUMERIC(8,2) = NULL,
	@SalePrice				NUMERIC(8, 2) = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_user
GOAL      : Create a new user                          
AUTHOR    : gisidorio
DATE      : 12/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO Products ([Name], [Description], PurchasePrice, SalePrice, IsActivated, RegisterDate)
	VALUES (@Name, @Description, @PurchasePrice, @SalePrice, 1, GETDATE())
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_product WAS SUCESSFULLY CREATED >>>'
END


