USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_client')
BEGIN 
	DROP PROCEDURE sp_insert_client
	PRINT '<<< PROCEDURE sp_insert_client WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_client
(	
	@Person					VARCHAR(9) = NULL,
	@Name					VARCHAR(60) = NULL,
	@EIN					VARCHAR(9) = NULL,
	@SSN					VARCHAR(10) = NULL,
	@Gender					VARCHAR(6)	= NULL,
	@Email					VARCHAR(100) = NULL,
	@Phone					VARCHAR(16) = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_client
GOAL      : Create a new client                          
AUTHOR    : gisidorio
DATE      : 08/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO Clients(Person, [Name], EIN, SSN, Gender, Email, Phone, IsActivated, RegisterDate)
	VALUES (@Person, @Name, @EIN, @SSN, @Gender, @Email, @Phone, 1, GETDATE())
	SELECT SCOPE_IDENTITY() 
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_client')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_client WAS SUCESSFULLY CREATED >>>'
END


