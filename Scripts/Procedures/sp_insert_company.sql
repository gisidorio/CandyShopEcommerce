USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_company')
BEGIN 
	DROP PROCEDURE sp_insert_company
	PRINT '<<< PROCEDURE sp_insert_company WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_company
(
	@Name					VARCHAR(60) = NULL,
	@EIN					VARCHAR(9) = NULL,
	@CityId					INT = 0,
	@IsParentCompany		BIT = 0,
	@IsActivated			BIT = 0,
	@RegisterDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_company                                        
GOAL      : Insert a new company 
AUTHOR    : gisidorio
DATE      : 16/06/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
17/06/2021		~001        gisidorio        return the generated key after insert
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO Companies ([Name], EIN, CityId, IsParentCompany, IsActivated, RegisterDate)
	VALUES (@Name, @EIN, @CityId, @IsParentCompany, @IsActivated, GETDATE())
	SELECT SCOPE_IDENTITY()
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_company')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_company WAS SUCESSFULLY CREATED >>>'
END


