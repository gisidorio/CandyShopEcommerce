USE LittleCandyShop
go

BEGIN TRANSACTION

-- search products by keyword
DECLARE @Keyword VARCHAR(50) = 'Cho'

	SELECT	prod.Id,
			prod.[Name],
			prod.[Description],
			prod.SalePrice
	INTO	#ProductsByKeyword
	FROM	KeywordsProducts AS kp
	JOIN	Keywords AS keyw
	ON		kp.KeywordId = keyw.Id
	JOIN	Products AS prod
	ON		prod.Id = kp.ProductId
	WHERE	keyw.Word LIKE '%' + @Keyword + '%'

	-- MOST SELLING PRODUCTS
	SELECT	*
	FROM	#ProductsByKeyword
	

ROLLBACK