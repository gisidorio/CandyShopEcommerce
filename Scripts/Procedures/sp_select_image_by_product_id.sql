USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_image_by_product_id')
BEGIN 
	DROP PROCEDURE sp_select_image_by_product_id
	PRINT '<<< PROCEDURE sp_select_image_by_product_id WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_image_by_product_id
(
	@Id		INT = NULL
)
AS
BEGIN 
	SELECT	imag.Id,
			imag.Directory,
			imag.ProductId
	FROM	Images	AS imag
	WHERE	imag.ProductId = @Id
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_image_by_product_id')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_image_by_product_id WAS SUCESSFULLY CREATED >>>'
END

