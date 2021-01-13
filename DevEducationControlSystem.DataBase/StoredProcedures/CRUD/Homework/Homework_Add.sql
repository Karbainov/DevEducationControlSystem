CREATE PROCEDURE [dbo].[Homework_Add]
	@ResourceID INT,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@IsDeleted bit,
	@IsSolutionRequred bit
AS
	INSERT INTO dbo.Homework(ResourceID, Name, Description, IsDeleted, IsSolutionRequired)
	VALUES(@ResourceID,	@Name, @Description, @IsDeleted, @IsSolutionRequred)
	
