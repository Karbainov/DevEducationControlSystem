CREATE PROCEDURE [dbo].[Homework_Theme_Update]
	@Id INT,
	@HomeworkId INT,
	@ThemeId INT
AS
	UPDATE [dbo].[Homework_Theme] SET
	HomeworkId = @HomeworkId,
	ThemeId = @ThemeId
WHERE Id = @Id;