﻿CREATE PROCEDURE [dbo].[SelectAllHomeworkByThemeId]
	@ThemeId int
as

select

	Homework.Id as HomeworkId,
	Homework.Name as Homework,
	[Resource].Links as ResourceLinks,
	[Resource].Images as ResourceImages

	from Homework
	
	left join Homework_Theme on Homework.Id = Homework_Theme.HomeworkId
	left join Theme on Homework_Theme.ThemeId = Theme.Id
	left join [Resource] on [Resource].Id = Homework.ResourceId

	where Theme.Id = @ThemeId and Homework.IsDeleted = 0
