USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_position')
BEGIN 
	DROP PROCEDURE sp_select_position
	PRINT '<<< PROCEDURE sp_select_position WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_position
(
	@Id					INT = 0,
	@Name				VARCHAR(60) = NULL,
	@InitialDate		DATETIME = NULL,
	@FinalDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_position                                        
GOAL      : Get all positions or one position by id                              
AUTHOR    : gisidorio
DATE      : 05/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT	posi.Id,
				posi.[Name],
				posi.RegisterDate
		FROM	Positions AS posi
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_position')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_position WAS SUCESSFULLY CREATED >>>'
END

