CREATE PROCEDURE [dbo].[Course_Theme_Add]
	@CourseId int,
	@ThemeId int
AS
INSERT [dbo].[Course_Theme] (CourseId, ThemeId) VALUES (@CourseId, @ThemeId)