USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_product_by_keyword')
BEGIN 
	DROP PROCEDURE sp_select_product_by_keyword
	PRINT '<<< PROCEDURE sp_select_product_by_keyword WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_product_by_keyword
(
	@Keyword		VARCHAR(50)
)
AS
BEGIN 
	SELECT	prod.Id,
			prod.[Name],
			prod.[Description],
			prod.SalePrice
	FROM	KeywordsProducts AS kp
	JOIN	Keywords AS keyw
	ON		kp.KeywordId = keyw.Id
	JOIN	Products AS prod
	ON		prod.Id = kp.ProductId
	WHERE	keyw.Word LIKE '%' + @Keyword + '%'
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_product_by_keyword')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_product_by_keyword WAS SUCESSFULLY CREATED >>>'
END



