CREATE PROCEDURE [dbo].[Course_Theme_Add]
	@CourseId int,
	@ThemeId int
AS
INSERT [dbo].[Course_Theme] (CourseId, ThemeID) VALUES (@CourseId, @ThemeId)