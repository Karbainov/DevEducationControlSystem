CREATE procedure [dbo].[Lesson_Theme_Update]
@ID int,
@LessonID int,
@ThemeID int
as
update [dbo].[Lesson_Theme]
set LessonId = @LessonID,ThemeId = @Theme_ID
where Id = @ID
