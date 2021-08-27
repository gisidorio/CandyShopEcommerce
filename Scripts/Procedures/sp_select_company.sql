USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_company')
BEGIN 
	DROP PROCEDURE sp_select_company
	PRINT '<<< PROCEDURE sp_select_company WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_company
(
	@Id					INT = 0,
	@Name				VARCHAR(60) = NULL,
	@EIN				VARCHAR(9) = NULL,
	@CityId				INT = 0,
	@CityName		    VARCHAR(60) = NULL,
	@IsParentCompany	BIT = 0,
	@IsActivated		BIT = 0,
	@InitialDate		DATETIME = NULL,
	@FinalDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_company                                        
GOAL      : Get all employees or one company by id                              
AUTHOR    : gisidorio
DATE      : 14/05/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT	c.Id,
				c.[Name],
				c.EIN,
				c.CityId,
				ci.CityName,
				c.IsParentCompany,
				c.IsActivated,
				c.RegisterDate
		FROM	Companies AS c
		JOIN	Cities	AS ci
		ON		c.CityId = ci.Id
		WHERE	(@EIN IS NULL OR c.EIN LIKE '%' + @EIN + '%')
		AND		(@CityName IS NULL OR ci.CityName LIKE '%' + @CityName + '%')
		AND		((@InitialDate IS NULL AND @FinalDate IS NULL) OR (c.RegisterDate BETWEEN @InitialDate AND @FinalDate))
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_company')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_company WAS SUCESSFULLY CREATED >>>'
END

keywords