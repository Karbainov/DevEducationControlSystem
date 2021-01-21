CREATE PROCEDURE [dbo].[SelectAllHomeworkByTheme]
	@ThemeId int
as

select

	Homework.Id as homeworkId,
	Homework.Name as homework,
	Homework.Description as description,
	[Resource].Links as links,
	[Resource].Images as images

	from Homework
	
	left join Homework_Theme on Homework.Id = Homework_Theme.HomeworkId
	left join Theme on Homework_Theme.ThemeId = Theme.id
	left join [Resource] on [Resource].Id = Homework.ResourceId

	where Theme.id = @ThemeId