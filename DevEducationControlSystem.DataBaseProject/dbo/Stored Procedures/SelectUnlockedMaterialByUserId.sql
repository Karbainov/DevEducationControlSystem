CREATE PROCEDURE [dbo].[SelectUnlockedMaterialByUserId]
@UserId INT
AS
BEGIN
DECLARE @Var TABLE (MaterialName nvarchar(100), Message nvarchar (1000), ResourceId INT, MaterialId INT, Links nvarchar (1000), Images nvarchar (1000))
INSERT @Var EXEC GetAllGroupMaterialsByUserId 44


SELECT 

MaterialName, [Message], ResourceId, AllM.MaterialId, Links, Images, LessonId, Theme.Id as MaterialThemeId, Theme.[Name] AS MaterialThemeName, Tag.[Name] AS TagList

FROM (SELECT * FROM @Var) AS AllM
LEFT JOIN
Theme_Material ON AllM.MaterialId = Theme_Material.MaterialId
LEFT JOIN
Theme ON Theme_Material.ThemeId=Theme.Id
LEFT JOIN
Lesson_Theme ON Theme.Id=Lesson_Theme.ThemeId
LEFT JOIN
Lesson ON Lesson.Id=Lesson_Theme.LessonId
JOIN
Material_Tag ON Material_Tag.MaterialId=AllM.MaterialId
JOIN
Tag ON Material_Tag.TagId=Tag.Id
WHERE
Lesson.LessonDate < GETDATE()
END