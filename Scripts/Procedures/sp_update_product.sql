USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_update_product')
BEGIN 
	DROP PROCEDURE sp_update_product
	PRINT '<<< PROCEDURE sp_update_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_update_product
(	
	@Id						INT = 0,
	@Name					VARCHAR(70) = NULL,
	@Description			TEXT = NULL,
	@PurchasePrice			NUMERIC(8,2) = NULL,
	@SalePrice				NUMERIC(8, 2) = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_update_product
GOAL      : Update product                          
AUTHOR    : gisidorio
DATE      : 22/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	UPDATE Products
	SET	   [Name] = @Name,
		   [Description] = @Description,
		   PurchasePrice = @PurchasePrice,
		   SalePrice = @SalePrice
	WHERE  Id = @Id
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_update_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_update_product WAS SUCESSFULLY CREATED >>>'
END
