USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_update_company_product')
BEGIN 
	DROP PROCEDURE sp_update_company_product
	PRINT '<<< PROCEDURE sp_update_company_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_update_company_product
(
	@CompanyId					INT = 0,
	@ProductId					INT = 0,
	@StockQuantity				INT = 0
)
AS
/*******************************************************************************************      
PROCEDURE : sp_update_company_product                                        
GOAL      : Update stock for a company                          
AUTHOR    : gisidorio
DATE      : 11/06/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	UPDATE CompaniesProducts
	SET	   StockQuantity = @StockQuantity
	WHERE  CompanyId = @CompanyId
	AND	   ProductId = @ProductId
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_update_company_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_update_company_product WAS SUCESSFULLY CREATED >>>'
END


