CREATE PROCEDURE [dbo].[SelectAllHomeworkByCourseId]
	@CourseId int
as

select  

	Homework.Id as HomeworkId,
	Homework.Name as Homework,
	Homework.StartDate as StartDate,
	Homework.DeadLine as DeadLine,
	[Resource].Id as ResourceId,
	[Resource].Links as ResourceLinks,
	[Resource].Images as ResourceImages

	from Homework
	Left join Homework_Course on homework.Id = Homework_Course.HomeworkId
	Left join Course on Course.Id = Homework_Course.CourseId
	left join [Resource] on Resource.Id = Homework.ResourceId
		
	where Course.Id = @CourseId and Homework.IsDeleted = 0 and Course.IsDeleted = 0
