CREATE PROCEDURE [dbo].[SelectAllHomeworkByCourse]
	@CourseId int
as

select  

	Homework.Id as homeworkId,
	Homework.Name as homework,
	Homework.Description as description,
	[Resource].Links as resourceLinks,
	[Resource].Images as resourceImages

	from Homework
	Left join Homework_Course on homeworkId = Homework_Course.HomeworkId
	Left join Course on Course.Id = Homework_Course.CourseId
	left join [Resource] on Resource.Id = Homework.ResourceId
		
	where Course.id = @CourseId

	order by homeworkId asc