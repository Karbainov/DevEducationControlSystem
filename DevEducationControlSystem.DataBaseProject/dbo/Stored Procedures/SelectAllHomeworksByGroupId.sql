CREATE PROCEDURE [dbo].[SelectAllHomeworksByGroupId]
	@GroupId int
AS
select H.Id, H.ResourceId, H.Name, H.Description, H.IsDeleted, H.IsSolutionRequired from Homework H
join [Group_Homework] on [Group_Homework].HomeworkId = H.Id
Where Group_Homework.GroupId = @GroupId
