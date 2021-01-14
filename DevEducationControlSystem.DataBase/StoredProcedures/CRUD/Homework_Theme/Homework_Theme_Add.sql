CREATE PROCEDURE [dbo].[Homework_Theme_Add]
	@HomeworkID INT,
	@ThemeID INT
AS
	INSERT INTO [dbo].[Homework_Theme](HomeworkID, ThemeID)
	VALUES(@HomeworkID,	@ThemeID)