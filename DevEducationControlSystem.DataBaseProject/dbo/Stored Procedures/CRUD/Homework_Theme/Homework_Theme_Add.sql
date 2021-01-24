CREATE PROCEDURE [dbo].[Homework_Theme_Add]
	@HomeworkId INT,
	@ThemeId INT
AS
	INSERT INTO [dbo].[Homework_Theme](HomeworkId, ThemeId)
	VALUES(@HomeworkId,	@ThemeId)