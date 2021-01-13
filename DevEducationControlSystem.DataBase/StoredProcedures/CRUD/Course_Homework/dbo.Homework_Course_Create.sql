CREATE PROCEDURE dbo.Homework_Course_Create 
	@CourseId int, 
	@HomeworkId int 
AS 
INSERT into Homework_Course VALUES (@CourseId, @HomeworkId)
