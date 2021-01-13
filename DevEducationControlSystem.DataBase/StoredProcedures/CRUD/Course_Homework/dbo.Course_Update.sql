CREATE PROCEDURE dbo.Course_Update
	@ID int,
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@DurationInWeeks int,
	@IsDeleted bit
AS
	UPDATE dbo.Course SET
		Name = @Name,
		Description = @Description,
		DurationInWeeks = @DurationInWeeks,
		IsDeleted = @IsDeleted
  WHERE ID = @ID
