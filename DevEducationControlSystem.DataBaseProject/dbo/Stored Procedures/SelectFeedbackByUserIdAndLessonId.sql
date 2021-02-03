CREATE PROCEDURE SelectFeedbackByUserIdAndLessonId
@UserId INT,
@LessonId INT
AS
BEGIN
	SELECT * FROM Feedback WHERE UserId=@UserId AND LessonId=@LessonId
END