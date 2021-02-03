CREATE PROCEDURE [dbo].[Homework_Course_Update]
	@Id INT,
	@HomeworkId INT,
	@CourseId INT
AS
	UPDATE [dbo].[Homework_Course] SET
	HomeworkID = @HomeworkId,
	CourseID = @CourseId
WHERE ID = @Id;
