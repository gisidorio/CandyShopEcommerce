USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_faq')
BEGIN 
	DROP PROCEDURE sp_insert_faq
	PRINT '<<< PROCEDURE sp_insert_faq WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_faq
(	
	@Question				VARCHAR(150) = NULL,
	@Answer					VARCHAR(300) = NULL,
	@ProductId				INT = 0
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_faq
GOAL      : Create a new FAQ                          
AUTHOR    : gisidorio
DATE      : 22/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO FAQ (Question, Answer, ProductId, RegisterDate)
	VALUES (@Question, @Answer, @ProductId, GETDATE())
	SELECT SCOPE_IDENTITY()
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_faq')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_faq WAS SUCESSFULLY CREATED >>>'
END


