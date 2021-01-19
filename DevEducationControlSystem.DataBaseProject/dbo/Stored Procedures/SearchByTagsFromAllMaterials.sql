CREATE PROCEDURE  SearchByTagsFromAllMaterials

@GroupId int,
@TagId int

AS
BEGIN

SELECT Tag.[Name] AS Tag, [Resource].Links, [Resource].Images
FROM
(SELECT ResourceId, GroupId, Material.Id AS MaterialId, Material.[Name] AS [Material name], Material.[Message] FROM
	[Material] 
	JOIN
	[Group_Material] ON [Material].Id = Group_Material.MaterialId
	LEFT JOIN
	[Course_Material] ON [Material].Id = Course_Material.MaterialId AND Group_Material.MaterialId <> Course_Material.MaterialId
)
AS AllGroupMaterials
JOIN
[Resource]ON [Resource].Id=AllGroupMaterials.ResourceId
JOIN
[Material_Tag] ON [Material_Tag].MaterialId=AllGroupMaterials.MaterialId
JOIN
[Tag] ON [Material_Tag].TagId=Tag.Id

WHERE GroupId=@GroupId AND TagId=@TagId
END