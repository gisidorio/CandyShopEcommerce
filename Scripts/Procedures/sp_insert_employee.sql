USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_employee')
BEGIN 
	DROP PROCEDURE sp_insert_employee
	PRINT '<<< PROCEDURE sp_insert_employee WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_insert_employee
(	
	@Name				VARCHAR(60) = NULL,
	@SSN				VARCHAR(9) = NULL,
	@Gender				VARCHAR(8) = NULL,
	@Salary				NUMERIC(8, 2) = NULL,
	@CompanyId			INT = 0,
	@DepartmentId		INT = 0,
	@PositionId			INT = 0,
	@IsActivated		BIT = 0	
)
AS
/*******************************************************************************************      
PROCEDURE : sp_insert_employee
GOAL      : Create a new employee                          
AUTHOR    : gisidorio
DATE      : 05/07/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	SET NOCOUNT ON
	INSERT INTO Employees ([Name], SSN, Gender, Salary, CompanyId, DepartmentId, PositionId, IsActivated, RegisterDate)
	VALUES (@Name, @SSN, @Gender, @Salary, @CompanyId, @DepartmentId, @PositionId, @IsActivated, GETDATE())
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_insert_employee')
BEGIN 
	PRINT '<<< PROCEDURE sp_insert_employee WAS SUCESSFULLY CREATED >>>'
END

select	*
from	Employees