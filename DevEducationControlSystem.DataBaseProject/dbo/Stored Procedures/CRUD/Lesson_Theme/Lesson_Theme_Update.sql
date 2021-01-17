CREATE procedure [dbo].[Lesson_Theme_Update]
@Id int,
@LessonId int,
@ThemeId int
as
update [dbo].[Lesson_Theme]
set LessonId = @LessonId,ThemeId = @ThemeId
where Id = @Id
