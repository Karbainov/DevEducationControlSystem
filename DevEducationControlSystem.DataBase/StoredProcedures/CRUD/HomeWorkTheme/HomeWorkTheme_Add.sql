CREATE PROCEDURE [dbo].[Homework_Theme_Add] 
	@HomeworkId int, 
	@ThemeId int 
AS 
INSERT [dbo].[Homework_Theme] (HomeworkID, ThemeID) VALUES (@HomeworkId, @ThemeId)
