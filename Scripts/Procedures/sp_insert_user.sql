USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_user')
BEGIN 
	DROP PROCEDURE sp_insert_user
	PRINT '<<< PROCEDURE sp_insert_user WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_user
(	
	@Username				VARCHAR(60) = NULL,
	@Password				VARCHAR(9) = NULL,
	@ClientId				VARCHAR(8) = NULL,
	@EmployeeId				NUMERIC(8, 2) = NULL,
	@IsActivated			BIT = 0	
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_user
GOAL      : Create a new user                          
AUTHOR    : gisidorio
DATE      : 08/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO Users(Username, [Password], ClientId, EmployeeId, IsActivated, RegisterDate)
	VALUES (@Username, @Password, @ClientId, @EmployeeId, @IsActivated, GETDATE())
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_user')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_user WAS SUCESSFULLY CREATED >>>'
END

SELECT	*
FROM	Clients
