CREATE PROCEDURE [dbo].[SelectAllHomeworkByGroup]
	@GroupId int
as
select

	[Homework].Id as HomeworkId,
	[Homework].Name as homework,
	[Homework].Description as [description],
	[Homework].IsSolutionRequired as IsSolutionRequired,
	[Resource].Links as resourceLinks,
	[Resource].Images as resourceImages

	from Homework
	Left join Group_Homework as GroupHomework on Homework.Id = GroupHomework.HomeworkId
	Left join [group] on [Group].Id = GroupHomework.GroupId
	left join [Resource] on Resource.Id = Homework.ResourceId

	WHERE [Group].Id = @GroupId