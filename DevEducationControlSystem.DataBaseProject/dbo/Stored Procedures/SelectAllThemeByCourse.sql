CREATE PROCEDURE [dbo].[SelectAllThemeOnCourse]
	@CourseId int
as

select 

	Theme.id as themeId,
	Theme.Name as theme

	from Theme  
	
	left join Course_Theme as CourseTheme on theme.Id = CourseTheme.ThemeId
	left join Course on Course.Id = CourseTheme.CourseId
 
	
	where Course.Id = @CourseId

	Order By themeId
