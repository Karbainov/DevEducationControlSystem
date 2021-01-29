CREATE PROCEDURE [dbo].[Group_Homework_Update]
	@Id int,
	@GroupId int,
	@HomeworkId int,
	@StartDate date,
	@DeadLine date
AS
	UPDATE Group_Homework
	SET
		GroupId = @GroupId,
		HomeworkId = @HomeworkId,
		StartDate = @StartDate,
		DeadLine = @DeadLine
WHERE
	Id=@Id