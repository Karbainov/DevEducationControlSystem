CREATE PROCEDURE [dbo].[Lesson_Theme_Add]
@Id int,
@LessonID int,
@ThemeID int
AS
INSERT into [dbo].[Lesson_Theme]
(Id, LessonId, ThemeId)
VALUES
(@Id, @LessonID, @ThemeID)