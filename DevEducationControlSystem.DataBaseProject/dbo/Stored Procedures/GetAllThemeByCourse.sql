CREATE PROCEDURE [dbo].[GetAllThemeOnCourse]
	@CourseId int
as

select 

	Theme.id as themeId,
	Theme.Name as theme

	from Theme  
	
	Left join Course_Theme as CourseTheme on themeId = CourseTheme.ThemeId
	Left join Course on Course.Id = CourseTheme.CourseId 
	
	where Course.Id = @CourseId

	Order By themeId
