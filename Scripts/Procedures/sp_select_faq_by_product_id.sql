USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_faq_by_product_id')
BEGIN 
	DROP PROCEDURE sp_select_faq_by_product_id
	PRINT '<<< PROCEDURE sp_select_faq_by_product_id WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_faq_by_product_id
(
	@Id		INT = NULL
)
AS
BEGIN 
	SELECT	f.Id,
			f.Question,
			f.Answer,
			f.ProductId,
			f.RegisterDate
	FROM	FAQ	AS f
	WHERE	f.ProductId = @Id
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_faq_by_product_id')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_faq_by_product_id WAS SUCESSFULLY CREATED >>>'
END

