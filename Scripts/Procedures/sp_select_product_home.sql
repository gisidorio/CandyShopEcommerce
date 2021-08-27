USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_product_home')
BEGIN 
	DROP PROCEDURE sp_select_product_home
	PRINT '<<< PROCEDURE sp_select_product_home WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_product_home
(
	@Id					INT = 0,
	@CompanyId			INT = 0,
	@Name				VARCHAR(60) = NULL,
	@PurchasePrice		NUMERIC(8, 2) = NULL,
	@SalePrice			NUMERIC(8, 2) = NULL,
	@Status				VARCHAR(12) = NULL,
	@InitialDate		DATETIME = NULL,
	@FinalDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_product                                        
GOAL      : Get all products or one product by id                              
AUTHOR    : gisidorio
DATE      : 25/08/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
-----------   ------------ --------------- ----------------------------------------------------  

-----------------------------------------------------------------------------------------------
12/07/2021      
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT		prod.Id,
					prod.[Name],
					prod.[Description],
					prod.PurchasePrice,
					prod.SalePrice,
					imag.Directory AS ImageDirectory,
					prod.IsActivated,
					prod.RegisterDate
		FROM		Products AS prod
		JOIN		Images AS imag
		ON			prod.Id = imag.ProductId
		WHERE		imag.Main = 1
	END	
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_product_home')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_product_home WAS SUCESSFULLY CREATED >>>'
END



