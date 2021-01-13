CREATE PROCEDURE [dbo].[Homework_Theme_Update]
	@ID INT,
	@HomeworkID INT,
	@ThemeID INT
AS
	UPDATE [dbo].[Homework_Theme] SET
	HomeworkID = @HomeworkID,
	ThemeID = @ThemeID
WHERE ID = @ID;