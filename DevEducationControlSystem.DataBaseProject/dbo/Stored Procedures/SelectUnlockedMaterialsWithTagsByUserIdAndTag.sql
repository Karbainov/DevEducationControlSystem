CREATE PROCEDURE [dbo].[SelectUnlockedMaterialsWithTagsByUserIdAndTag]

@UserId INT,
@Tag nvarchar(100)

AS

BEGIN

DECLARE @var table (MaterialName nvarchar(100), [Message] nvarchar(1000), ResourceId int, MaterialId int, Links nvarchar(1000), Images nvarchar(1000))
INSERT @var EXEC GetAllGroupMaterialsByUserId @UserId


SELECT AllM.MaterialId, AllM.[MaterialName], AllM.[Message], Links, Images, Tag.[Name] AS TagName FROM
(

SELECT AllGroupMaterials.[MaterialName],
AllGroupMaterials.[Message],
Tag.[Name] AS Tag,
[Resource].Links,
[Resource].Images,
AllGroupMaterials.MaterialId
FROM

(SELECT * FROM  @var)
AS AllGroupMaterials

JOIN
[Resource]ON [Resource].Id=AllGroupMaterials.ResourceId
JOIN
[Material_Tag] ON [Material_Tag].MaterialId=AllGroupMaterials.MaterialId
JOIN
[Tag] ON [Material_Tag].TagId=Tag.Id AND Material_Tag.MaterialId=AllGroupMaterials.MaterialId

WHERE Tag.[Name]=@Tag
) AS AllM
JOIN
Material_Tag ON AllM.MaterialId=Material_Tag.MaterialId
JOIN
Tag ON Tag.Id=Material_Tag.TagId
LEFT JOIN
Theme_Material ON AllM.MaterialId = Theme_Material.MaterialId
LEFT JOIN
Theme ON Theme_Material.ThemeId=Theme.Id
LEFT JOIN
Lesson_Theme ON Theme.Id=Lesson_Theme.ThemeId
LEFT JOIN
Lesson ON Lesson.Id=Lesson_Theme.LessonId
WHERE
Lesson.LessonDate < GETDATE()

END