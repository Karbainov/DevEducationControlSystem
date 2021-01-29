CREATE PROCEDURE [dbo].[SelectAllHomeworkByGroupId]
	@GroupId int
as
select

	H.Id, H.Name, H.Description, H.IsSolutionRequired,
	GH.StartDate, GH.DeadLine,
	R.Id as ResourceId,	R.Links, R.Images

	from Homework as H
	Left join Group_Homework as GH on H.Id = GH.HomeworkId
	Left join [group] on [Group].Id = GH.GroupId
	left join [Resource] as R on R.Id = H.ResourceId

	where [Group].Id = @GroupId and H.IsDeleted=0