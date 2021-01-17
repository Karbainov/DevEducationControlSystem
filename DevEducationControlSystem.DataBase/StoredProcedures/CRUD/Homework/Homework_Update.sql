CREATE PROCEDURE [dbo].[Homework_Update]
	@ID int,
	@ResourceID INT,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@IsDeleted bit,
	@IsSolutionRequred bit
AS
	UPDATE dbo.Homework SET
		ResourceID = @ResourceID,
		Name = @Name,
		Description = @Description,
		IsDeleted = @IsDeleted,
		IsSolutionRequired = @IsSolutionRequred
  WHERE ID = @ID
	