USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_login')
BEGIN 
	DROP PROCEDURE sp_login
	PRINT '<<< PROCEDURE sp_login WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_login
(
	@Username			VARCHAR(60) = NULL,
	@Password			VARCHAR(40) = NULL	
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_user                                        
GOAL      : Login                           
AUTHOR    : gisidorio
DATE      : 08/09/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SELECT	[user].Id,
	        [user].Username,
			[user].[Password],
			[user].ClientId,
			[user].EmployeeId,
			[user].IsActivated,
			[user].RegisterDate
	FROM	Users AS [user]
	WHERE	[user].Username = @Username
	AND		[user].[Password] = @Password
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_login')
BEGIN 
	PRINT '<<< PROCEDURE sp_login WAS SUCESSFULLY CREATED >>>'
END





