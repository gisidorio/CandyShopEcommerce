USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_keyword_not_in_product')
BEGIN 
	DROP PROCEDURE sp_select_keyword_not_in_product
	PRINT '<<< PROCEDURE sp_select_keyword_not_in_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_keyword_not_in_product
(
	@Id					INT = 0	
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_keyword_not_in_product                                        
GOAL      : Get all keywors that they are not in product set                           
AUTHOR    : gisidorio
DATE      : 22/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
-----------   ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN

	DECLARE @ProductId	INT = @Id

	SELECT	keyw.Id,
			keyw.Word
	FROM	Keywords AS keyw
	WHERE NOT EXISTS (
		SELECT	1
		FROM	KeywordsProducts AS keywprod
		WHERE	keywprod.KeywordId = keyw.Id
		AND		keywprod.ProductId = @ProductId
	)

END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_keyword_not_in_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_keyword_not_in_product WAS SUCESSFULLY CREATED >>>'
END



