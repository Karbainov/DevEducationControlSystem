CREATE PROCEDURE [dbo] . [Feedback_Update]

	@Id int,
	@UserId int,
	@LessonId int,
	@Rate int,
	@Message nvarchar (1000)
AS 
	UPDATE [dbo] . [Feedback]
	SET 
		UserId = @UserId, 
		LessonId = @LessonId,
		Rate = @Rate,
		Message = @Message
WHERE 
	Id=@Id
