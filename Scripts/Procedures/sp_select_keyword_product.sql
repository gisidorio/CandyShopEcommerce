USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_keyword_product')
BEGIN 
	DROP PROCEDURE sp_select_keyword_product
	PRINT '<<< PROCEDURE sp_select_keyword_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_keyword_product
(
	@ProductId					INT = 0
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_keyword_product                                        
GOAL      : Get all keywords by product                           
AUTHOR    : gisidorio
DATE      : 22/05/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
		SELECT	keywprod.KeywordId,
				keywprod.ProductId,
				keyw.Word,
				keyw.RegisterDate
		FROM	KeywordsProducts AS keywprod
		JOIN	Keywords AS keyw
		ON		keywprod.KeywordId = keyw.Id
		WHERE	keywprod.ProductId = @ProductId
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_keyword_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_keyword_product WAS SUCESSFULLY CREATED >>>'
END