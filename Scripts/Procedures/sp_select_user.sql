USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_user')
BEGIN 
	DROP PROCEDURE sp_select_user
	PRINT '<<< PROCEDURE sp_select_user WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_user
(
	@Id					INT = 0,
	@Username			VARCHAR(60) = NULL,
	@Password			VARCHAR(40) = NULL,
	@ClientId			INT = 0,
	@EmployeeId			INT = 0,
	@IsActivated		BIT = 0,
	@InitialDate		DATETIME = NULL,
	@FinalDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_user                                        
GOAL      : Get all users or one user by id                              
AUTHOR    : gisidorio
DATE      : 07/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT	[user].Id,
		        [user].Username,
				[user].[Password],
				[user].ClientId,
				[user].EmployeeId,
				[user].IsActivated,
				[user].RegisterDate
		FROM	Users AS [user]
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_user')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_user WAS SUCESSFULLY CREATED >>>'
END





