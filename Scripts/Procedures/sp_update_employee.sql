USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_update_employee')
BEGIN 
	DROP PROCEDURE sp_update_employee
	PRINT '<<< PROCEDURE sp_update_employee WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_update_employee
(	
	@Id					INT = 0,
	@Name				VARCHAR(60) = NULL,
	@SSN				VARCHAR(10) = NULL,
	@Gender				VARCHAR(8) = NULL,
	@Salary				NUMERIC(8, 2) = NULL,
	@CompanyId			INT = 0,
	@DepartmentId		INT = 0,
	@PositionId			INT = 0,
	@IsActivated		BIT = 0	
)
AS
/*******************************************************************************************      
PROCEDURE : sp_update_employee
GOAL      : Update employee                          
AUTHOR    : gisidorio
DATE      : 06/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	UPDATE Employees
	SET	   [Name] = @Name,
		   SSN = @SSN,
		   Gender = @Gender,
		   Salary = @Salary,
		   CompanyId = @CompanyId,
		   DepartmentId = @DepartmentId,
		   PositionId = @PositionId,
		   IsActivated = @IsActivated
	WHERE  Id = @Id
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_update_employee')
BEGIN 
	PRINT '<<< PROCEDURE sp_update_employee WAS SUCESSFULLY CREATED >>>'
END
