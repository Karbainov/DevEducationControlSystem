CREATE PROCEDURE [dbo].[Homework_Add]
	@ResourceID INT,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@IsSolutionRequred bit
AS
	INSERT INTO dbo.Homework(ResourceID, Name, Description, IsSolutionRequired)
	VALUES(@ResourceID,	@Name, @Description, @IsSolutionRequred)
	
