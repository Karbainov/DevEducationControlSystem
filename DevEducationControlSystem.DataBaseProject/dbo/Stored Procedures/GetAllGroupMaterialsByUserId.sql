CREATE PROCEDURE GetAllGroupMaterialsByUserId
	@UserId int
AS

BEGIN
	
	DECLARE @GroupId int;
	SET @GroupId = (SELECT GroupId FROM User_Group WHERE UserId=@UserId);

	SELECT ResourceId, MaterialId, Links, Images FROM
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