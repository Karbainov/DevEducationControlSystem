CREATE PROCEDURE SelectInlockedMaterialByUserId
@UserId INT
AS
BEGIN
DECLARE @Var TABLE (MaterialName nvarchar(100), Message nvarchar (1000), ResourceId INT, MaterialId INT, Links nvarchar (1000), Imager nvarchar (1000))
INSERT @Var EXEC GetAllGroupMaterialsByUserId @UserId


SELECT * FROM (SELECT * FROM @Var) AS AllM
LEFT JOIN
Theme_Material ON AllM.MaterialId = Theme_Material.MaterialId
LEFT JOIN
Theme ON Theme_Material.MaterialId=Theme.Id
LEFT JOIN
Lesson_Theme ON Theme.Id=Lesson_Theme.ThemeId
LEFT JOIN
Lesson ON Lesson.Id=Lesson_Theme.LessonId
WHERE
Lesson.LessonDate < GETDATE()
END