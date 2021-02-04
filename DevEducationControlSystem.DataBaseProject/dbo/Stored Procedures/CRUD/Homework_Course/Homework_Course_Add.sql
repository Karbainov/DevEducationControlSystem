CREATE PROCEDURE [dbo].[Homework_Course_Add] 
	@CourseId int, 
	@HomeworkId int 
AS 
INSERT into [dbo].[Homework_Course](CourseId, HomeworkId) 
VALUES (@CourseId, @HomeworkId)
