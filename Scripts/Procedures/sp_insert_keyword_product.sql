USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_keyword_product')
BEGIN 
	DROP PROCEDURE sp_insert_keyword_product
	PRINT '<<< PROCEDURE sp_insert_keyword_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_keyword_product
(
	@KeywordId					INT = 0,
	@ProductId					INT = 0
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_company_product                                        
GOAL      : Insert a new product for a company                          
AUTHOR    : gisidorio
DATE      : 25/08/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO KeywordsProducts(KeywordId, ProductId)
	VALUES (@KeywordId, @ProductId)
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_keyword_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_keyword_product WAS SUCESSFULLY CREATED >>>'
END


