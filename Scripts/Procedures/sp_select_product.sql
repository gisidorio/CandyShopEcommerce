USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_product')
BEGIN 
	DROP PROCEDURE sp_select_product
	PRINT '<<< PROCEDURE sp_select_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_product
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
DATE      : 17/05/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
-----------   ------------ --------------- ----------------------------------------------------  
20/05/2021		~001		gisidorio		Select all products without association in 
											CompaniesProducts table
-----------------------------------------------------------------------------------------------
12/07/2021      
*********************************************************************************************/
BEGIN

-- ~001 begin --
	IF (@CompanyId <> 0)
	BEGIN 
		SELECT		Prod.Id,
					Prod.[Name],
					Prod.[Description],
					Prod.PurchasePrice,
					Prod.SalePrice,
					Prod.IsActivated,
					Prod.RegisterDate
		FROM		Products AS Prod
		WHERE		NOT EXISTS (
			SELECT		1
			FROM		CompaniesProducts AS CompProd
			WHERE		CompProd.ProductId = Prod.Id
			AND			CompProd.CompanyId = @CompanyId
		)
	END
	-- ~001 end --

	IF (@Id = 0)
	BEGIN 
		SELECT		prod.Id,
					prod.[Name],
					prod.[Description],
					prod.PurchasePrice,
					prod.SalePrice,
					prod.IsActivated,
					prod.RegisterDate
		FROM		Products AS prod
	END	
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_product WAS SUCESSFULLY CREATED >>>'
END



