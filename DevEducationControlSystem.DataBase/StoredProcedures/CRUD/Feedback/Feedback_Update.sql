CREATE PROCEDURE [dbo] . [Feedback_Update]

	@Id int,
	@UserId int,
	@LessonId int,
	@Message nvarchar (1000)
AS 
	UPDATE [dbo] . [Feedback]
	SET 
		UserId = @UserId, 
		LessonId = @LessonId,
		Message = @Message
WHERE 
	ID=@Id
