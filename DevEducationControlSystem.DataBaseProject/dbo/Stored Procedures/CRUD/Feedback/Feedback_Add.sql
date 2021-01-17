CREATE PROCEDURE [dbo] . [Feedback_Add]
	@UserId int, 
	@LessonId int,
	@Message nvarchar (1000)
AS 
INSERT [dbo] . [Feedback] VALUES (@UserId, @LessonId, @Message)
