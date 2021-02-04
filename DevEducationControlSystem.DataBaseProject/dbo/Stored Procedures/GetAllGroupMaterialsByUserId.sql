CREATE PROCEDURE [dbo].[GetAllGroupMaterialsByUserId]
	@UserId int
AS

BEGIN
	
	DECLARE @GroupId int;
	SET @GroupId = (SELECT GroupId FROM User_Group JOIN [Group] ON User_Group.GroupId = [Group].Id WHERE UserId=@UserId AND StatusId>2 AND StatusId<6);

	SELECT Material.[Name] as MaterialName, Material.[Message], ResourceId, MaterialId, Links, Images FROM
	(
	SELECT Course_Material.MaterialId FROM Course_Material
		WHERE [Course_Material].[CourseId] = (SELECT [Group].[CourseId] FROM [Group] WHERE Id=@GroupId)
	UNION
	SELECT Group_Material.MaterialId FROM Group_Material WHERE Group_Material.GroupId=@GroupId
	) AS AllGroupMaterials
	JOIN
	[Material] ON AllGroupMaterials.MaterialId=Material.Id
	JOIN
	[Resource] On [Resource].Id=Material.ResourceId

END