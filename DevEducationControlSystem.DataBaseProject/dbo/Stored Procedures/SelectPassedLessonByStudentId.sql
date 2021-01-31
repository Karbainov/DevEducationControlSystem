CREATE PROCEDURE SelectPassedLessonByStudentId
@UserId INT
AS
BEGIN
SELECT Lesson.[Name] AS LessonName, LessonDate, Comments FROM
Lesson
JOIN [Group] ON Lesson.GroupId=[Group].Id
WHERE GroupId = (SELECT GroupId FROM User_Group WHERE UserId=@UserId) AND LessonDate<GETDATE()
END