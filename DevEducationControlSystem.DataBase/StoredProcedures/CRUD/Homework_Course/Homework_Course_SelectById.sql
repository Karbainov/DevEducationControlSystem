CREATE PROCEDURE [dbo].[Homework_Course_SelectById]
	@Id int 
AS 
	SELECT * FROM dbo.Homework_Course
	WHERE dbo.Homework_Course.Id=@Id 