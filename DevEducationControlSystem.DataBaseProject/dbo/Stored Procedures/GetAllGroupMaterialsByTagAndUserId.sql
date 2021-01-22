CREATE PROCEDURE  [dbo].[GetAllGroupMaterialsByTagAndUserId]

@UserId int,
@TagName nvarchar(100)

AS
BEGIN

DECLARE @GroupId int;
	SET @GroupId = (SELECT GroupId FROM User_Group WHERE UserId=@UserId);

DECLARE @var table (ResourceId int, MaterialId int, Links nvarchar(1000), Images nvarchar(1000))
INSERT @var EXEC GetAllGroupMaterialsByUserId 17

SELECT Tag.[Name] AS Tag, [Resource].Links, [Resource].Images, AllGroupMaterials.MaterialId
FROM

(SELECT * FROM  @var)
AS AllGroupMaterials

JOIN
[Resource]ON [Resource].Id=AllGroupMaterials.ResourceId
JOIN
[Material_Tag] ON [Material_Tag].MaterialId=AllGroupMaterials.MaterialId
JOIN
[Tag] ON [Material_Tag].TagId=Tag.Id

WHERE Tag.[Name]=@TagName
END