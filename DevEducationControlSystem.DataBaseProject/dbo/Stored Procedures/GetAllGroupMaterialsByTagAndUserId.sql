CREATE PROCEDURE  [dbo].[GetAllGroupMaterialsByTagAndUserId]

@UserId int,
@TagName nvarchar(100)

AS
BEGIN
--переиспользование GetAllGroupMaterialByUserId, как сделать? SELECT * FROM(EXEC имя_процедуры) не работает
DECLARE @GroupId int;
	SET @GroupId = (SELECT GroupId FROM User_Group WHERE UserId=@UserId);
--конец переиспользования

SELECT Tag.[Name] AS Tag, [Resource].Links, [Resource].Images, AllGroupMaterials.MaterialId
FROM
--переиспользование GetAllGroupMaterialByUserId, как сделать? SELECT * FROM(EXEC имя_процедуры) не работает
	(SELECT ResourceId, MaterialId, Links, Images FROM
	(
	SELECT Course_Material.MaterialId FROM Course_Material
		WHERE [Course_Material].[CourseId] = (SELECT [Group].[CourseId] FROM [Group] WHERE Id=@GroupId)
	UNION
	SELECT Group_Material.MaterialId FROM Group_Material WHERE Group_Material.GroupId=@GroupId
	) AS AllGroupMaterials
	JOIN
	[Material] ON AllGroupMaterials.MaterialId=Material.Id
	JOIN
	[Resource] On [Resource].Id=Material.ResourceId)
AS AllGroupMaterials
--конец переиспользования
JOIN
[Resource]ON [Resource].Id=AllGroupMaterials.ResourceId
JOIN
[Material_Tag] ON [Material_Tag].MaterialId=AllGroupMaterials.MaterialId
JOIN
[Tag] ON [Material_Tag].TagId=Tag.Id

WHERE Tag.[Name]=@TagName
END