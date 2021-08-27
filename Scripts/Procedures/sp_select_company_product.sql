USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_company_product')
BEGIN 
	DROP PROCEDURE sp_select_company_product
	PRINT '<<< PROCEDURE sp_select_company_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_company_product
(
	@CompanyId					INT = 0
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_company_product                                        
GOAL      : Get all products or one product by id                              
AUTHOR    : gisidorio
DATE      : 18/05/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN

		SELECT	CompProd.CompanyId,
				CompProd.ProductId,
				prod.[Name],
				CompProd.StockQuantity
		FROM	CompaniesProducts AS CompProd
		JOIN	Products AS prod
		ON		CompProd.ProductId = prod.Id
		WHERE	CompProd.CompanyId = @CompanyId
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_company_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_company_product WAS SUCESSFULLY CREATED >>>'
END