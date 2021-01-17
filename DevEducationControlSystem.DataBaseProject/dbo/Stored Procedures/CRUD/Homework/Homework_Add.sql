CREATE PROCEDURE [dbo].[Homework_Add]
	@ResourceId INT,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@IsSolutionRequred bit
AS
	INSERT INTO dbo.Homework(ResourceId, Name, Description, IsSolutionRequired)
	VALUES(@ResourceId,	@Name, @Description, @IsSolutionRequred)
	
