USE LittleCandyShop
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_employee')
BEGIN 
	DROP PROCEDURE sp_select_employee
	PRINT '<<< PROCEDURE sp_select_employee WAS SUCESSFULLY DROPPED >>>'
END
GO

CREATE PROCEDURE sp_select_employee
(
	@Id					INT = 0,
	@Name				VARCHAR(60) = NULL,
	@SSN				VARCHAR(9) = NULL,
	@Gender				VARCHAR(8) = NULL,
	@Salary				NUMERIC(8, 2) = NULL,
	@CompanyId			INT = 0,
	@DepartmentId		INT = 0,
	@PositionId			INT = 0,
	@IsActivated		BIT = 0,
	@InitialDate		DATETIME = NULL,
	@FinalDate			DATETIME = NULL
)
AS
/*******************************************************************************************      
PROCEDURE : sp_select_employee                                        
GOAL      : Get all employees or one company by id                              
AUTHOR    : gisidorio
DATE      : 24/05/2021                                                             
--------------------------------UPDATES-----------------------------------------------------      
DATE            TASK        AUTHOR           GOAL                                                   
---------- ------------ --------------- ----------------------------------------------------  
*********************************************************************************************/
BEGIN
	IF (@Id = 0)
	BEGIN 
		SELECT	empl.Id,
				empl.[Name],
				empl.SSN,
				empl.Gender,
				empl.Salary,
				empl.CompanyId,
				comp.[Name] AS CompanyName,
				empl.DepartmentId,
				depa.[Name] AS DepartmentName,
				empl.PositionId,
				posi.[Name] AS PositionName,
				empl.IsActivated,
				empl.RegisterDate
		FROM	Employees AS empl
		JOIN	Companies AS comp
		ON		empl.CompanyId = comp.Id
		JOIN	Departments AS depa
		ON		empl.DepartmentId = depa.Id
		JOIN	Positions AS posi
		ON		empl.PositionId = posi.Id
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE xtype = 'P' AND name = 'sp_select_employee')
BEGIN 
	PRINT '<<< PROCEDURE sp_select_employee WAS SUCESSFULLY CREATED >>>'
END

