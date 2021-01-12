CREATE PROCEDURE Feedback_Update 

	@Id int,
	@UserId int,
	@LessonId int,
	@Message nvarchar (1000)
AS 
	UPDATE Feedback
	SET 
		UserId = @UserId, 
		LessonId = @LessonId,
		Message = @Message
WHERE 
	ID=@Id
