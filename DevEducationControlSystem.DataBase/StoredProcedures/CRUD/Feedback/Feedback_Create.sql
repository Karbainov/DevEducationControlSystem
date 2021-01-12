CREATE PROCEDURE Feedback_Create 
	@UserId int, 
	@LessonId int,
	@Message nvarchar (1000)
AS 
INSERT Feedback VALUES (@UserId, @LessonId, @Message)
