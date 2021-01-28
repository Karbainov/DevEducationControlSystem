CREATE PROCEDURE [dbo].[SelectAllHomeworkByGroup]
	@GroupId int
as
select

	[Homework].Id as HomeworkId,
	[Homework].Name as Homework,
	[Homework].Description as [Description],
	[Homework].IsSolutionRequired as IsSolutionRequired,
	[Resource].Links as ResourceLinks,
	[Resource].Images as ResourceImages

	from Homework
	Left join Group_Homework as GroupHomework on Homework.Id = GroupHomework.HomeworkId
	Left join [Group] on [Group].Id = GroupHomework.GroupId
	left join [Resource] on Resource.Id = Homework.ResourceId

	where [Group].Id = @GroupId and Homework.IsDeleted = 0

	order by HomeworkId asc