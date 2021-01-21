CREATE PROCEDURE [dbo] . [Feedback_Add]
	@UserId int, 
	@LessonId int,
	@Rate int,
	@Message nvarchar (1000)
AS 
INSERT [dbo] . [Feedback] 
(UserId, LessonId, Rate, Message)
VALUES (@UserId, @LessonId, @Rate, @Message)
