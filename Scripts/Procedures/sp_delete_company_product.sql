USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_delete_company_product')
BEGIN 
	DROP PROCEDURE sp_delete_company_product
	PRINT '<<< PROCEDURE sp_delete_company_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_delete_company_product
(
	@CompanyId					INT = 0,
	@ProductId					INT = 0
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
	DELETE FROM CompaniesProducts 
	WHERE	CompanyId = @CompanyId
	AND		ProductId = @ProductId
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_delete_company_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_delete_company_product WAS SUCESSFULLY CREATED >>>'
END