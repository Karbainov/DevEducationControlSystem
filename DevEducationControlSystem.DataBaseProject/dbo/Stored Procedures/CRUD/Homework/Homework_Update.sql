CREATE PROCEDURE [dbo].[Homework_Update]
	@Id int,
	@ResourceId INT,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@IsDeleted bit,
	@IsSolutionRequred bit
AS
	UPDATE dbo.Homework SET
		ResourceId = @ResourceId,
		Name = @Name,
		Description = @Description,
		IsDeleted = @IsDeleted,
		IsSolutionRequired = @IsSolutionRequred
  WHERE Id = @Id
	