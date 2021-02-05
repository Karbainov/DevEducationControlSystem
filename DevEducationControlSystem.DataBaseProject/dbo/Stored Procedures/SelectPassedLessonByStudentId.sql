CREATE PROCEDURE [dbo].[SelectPassedLessonByStudentId]
@UserId INT
AS
BEGIN
SELECT Lesson.Id AS LessonId, Lesson.[Name] AS LessonName, LessonDate, Comments, Theme.[Name] AS ThemeName FROM
Lesson
JOIN [Group] ON Lesson.GroupId=[Group].Id
LEFT JOIN Lesson_Theme ON Lesson_Theme.LessonId = Lesson.Id 
LEFT JOIN Theme ON Theme.Id=Lesson_Theme.ThemeId
WHERE GroupId = (SELECT GroupId FROM User_Group JOIN [Group] ON User_Group.GroupId = [Group].Id WHERE UserId=@UserId AND StatusId>2 AND StatusId<6) AND LessonDate<GETDATE()
END