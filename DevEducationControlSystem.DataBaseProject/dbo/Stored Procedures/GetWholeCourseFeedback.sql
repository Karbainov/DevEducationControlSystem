CREATE PROCEDURE [dbo].[GetWholeCourseFeedback]

  @CourseId int

  AS
  BEGIN
  
  SELECT

	UserId,
	[User].FirstName,
	[User].LastName,
	GroupId,
	FeedbackId,
	Part1.LessonId,
	Rate,
	[Message],
	Theme.Id AS ThemeId,
	Theme.[Name] AS ThemeName

FROM
(
SELECT
	
	Feedback.Id AS FeedbackId,
	[Group].CourseId AS CourseId,
	Feedback.UserId AS UserId,
	Lesson.GroupId AS GroupId,
	Feedback.LessonId AS LessonId,
	Feedback.Rate AS Rate,
	Feedback.[Message] AS [Message]

FROM Feedback
JOIN
[Lesson] ON Feedback.LessonId=Lesson.Id
JOIN
[Group] on [Lesson].GroupId=[Group].Id
WHERE CourseId=@CourseId
) AS Part1
LEFT JOIN
Lesson_Theme ON Part1.LessonId=Lesson_Theme.LessonId
LEFT JOIN
Theme ON Theme.Id=Lesson_Theme.ThemeId
LEFT JOIN
Course ON Course.Id=Part1.CourseId
LEFT JOIN
[User] ON [User].Id=Part1.UserId

  END