CREATE PROCEDURE [dbo].[SelectAllMaterialsByGroupId]
	@GroupId int
AS
select M.Id, M.UserId, M.ResourceId, M.Name, M.Message, M.IsDeleted from Material M
join [Group_Material] on [Group_Material].MaterialId = M.Id
Where Group_Material.GroupId = @GroupId
