CREATE PROCEDURE GetAllGroupMaterialsId
	@UserId int
AS

BEGIN
	
	DECLARE @GroupId int;
	SET @GroupId = (SELECT GroupId FROM User_Group WHERE UserId=@UserId);



	SELECT Course_Material.MaterialId INTO AllGroupMaterials FROM Course_Material
		WHERE [Course_Material].[CourseId] = (SELECT [Group].[CourseId] FROM [Group] WHERE Id=@GroupId)
	UNION
	SELECT Group_Material.MaterialId FROM Group_Material WHERE Group_Material.GroupId=@GroupId;

	SELECT * FROM [Resource] WHERE Id IN
		(SELECT ResourceId FROM Material WHERE Id IN (SELECT MaterialId FROM AllGroupMaterials))

	DROP TABLE AllGroupMaterials

END
