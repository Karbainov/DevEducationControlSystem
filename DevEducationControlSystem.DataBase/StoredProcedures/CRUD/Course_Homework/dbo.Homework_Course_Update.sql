CREATE PROCEDURE dbo.Homework_Course_Update
	@ID INT,
	@HomeworkID INT,
	@CourseID INT
AS
	UPDATE [dbo].[Homework_Course] SET
	HomeworkID = @HomeworkID,
	CourseID = @CourseID
WHERE ID = @ID;
