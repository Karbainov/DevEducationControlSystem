CREATE PROCEDURE [dbo].[Homework_Add]
	@ResourceId INT,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@StartDate date,
	@DeadLine date,
	@IsSolutionRequred bit
AS
	INSERT INTO dbo.Homework(ResourceId, Name, Description, StartDate, DeadLine, IsSolutionRequired)
	VALUES(@ResourceId,	@Name, @Description, @StartDate, @DeadLine, @IsSolutionRequred)
	
