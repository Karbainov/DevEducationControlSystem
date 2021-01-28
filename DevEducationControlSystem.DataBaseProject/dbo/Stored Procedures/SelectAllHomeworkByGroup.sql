CREATE PROCEDURE [dbo].[SelectAllHomeworkByGroup]
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2
RETURN 0

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