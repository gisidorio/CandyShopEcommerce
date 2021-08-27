USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_department')
BEGIN 
	DROP PROCEDURE sp_select_department
	PRINT '<<< PROCEDURE sp_select_department WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_department
(
	@Id					INT = 0,
	@Name				VARCHAR(60) = NULL,
	@InitialDate		DATETIME = NULL,
	@FinalDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_department                                        
GOAL      : Get all departments or one department by id                              
AUTHOR    : gisidorio
DATE      : 05/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT	depa.Id,
				depa.[Name],
				depa.RegisterDate
		FROM	Departments AS depa
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_department')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_department WAS SUCESSFULLY CREATED >>>'
END

