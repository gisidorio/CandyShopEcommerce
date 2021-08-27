USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_faq_product')
BEGIN 
	DROP PROCEDURE sp_select_faq_product
	PRINT '<<< PROCEDURE sp_select_faq_product WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_faq_product
(
	@Id					INT = 0
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_faq_product                                        
GOAL      : Get all faqs by product                           
AUTHOR    : gisidorio
DATE      : 22/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
		SELECT	f.Id,
				f.Question,
				f.Answer,
				f.ProductId,
				f.RegisterDate
		FROM	FAQ AS f
		WHERE	f.ProductId = @Id
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_faq_product')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_faq_product WAS SUCESSFULLY CREATED >>>'
END