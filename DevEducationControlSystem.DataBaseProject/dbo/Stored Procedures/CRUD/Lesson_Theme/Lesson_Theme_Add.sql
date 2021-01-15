CREATE PROCEDURE [dbo].[Lesson_Theme_Add]
@ID int,
@LessonID int,
@ThemeID int
AS
INSERT into [dbo].[Lesson_Theme]
(Id, LessonId, ThemeId)
VALUES
(@ID, @LessonID, @ThemeID)