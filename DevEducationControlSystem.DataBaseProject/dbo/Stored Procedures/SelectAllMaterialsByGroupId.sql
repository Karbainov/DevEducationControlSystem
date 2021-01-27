CREATE PROCEDURE [dbo].[SelectAllMaterialsByGroupId]
	@GroupId int
AS
select
	M.Id,
	M.Name,
	M.Message,
	R.Links,
	R.Images
from Material M
	Left join [Group_Material] on [Group_Material].MaterialId = M.Id
	Left join [group] on [Group].Id = [Group_Material].GroupId
	left join [Resource] R on R.Id = M.ResourceId
Where Group_Material.GroupId = @GroupId and M.IsDeleted = 0
