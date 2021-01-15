CREATE procedure [dbo].[Lesson_Theme_SelectById]
@ID int
as
select * from [dbo].[Lesson_Theme] where Id = @ID