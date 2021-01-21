CREATE PROCEDURE [dbo] . [Feedback_Add]
	@UserId int, 
	@LessonId int,
	@Message nvarchar (1000)
AS 
INSERT [dbo] . [Feedback] 
(UserId, LessonId, Message)
VALUES (@UserId, @LessonId, @Message)
