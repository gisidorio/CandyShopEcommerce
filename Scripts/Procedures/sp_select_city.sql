USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_city')
BEGIN 
	DROP PROCEDURE sp_select_city
	PRINT '<<< PROCEDURE sp_select_city WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_city
(
	@Id					INT = 0,
	@StateId			INT = 0,
	@CityName		    VARCHAR(60) = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_city                                        
GOAL      : Get all cities                          
AUTHOR    : gisidorio
DATE      : 16/06/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT	citi.Id,
				citi.StateId,
				citi.CityName
		FROM	Cities AS citi
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_city')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_city WAS SUCESSFULLY CREATED >>>'
END