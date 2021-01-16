CREATE procedure [dbo].[Lesson_Theme_SelectById]
@Id int
as
select * from [dbo].[Lesson_Theme] where Id = @Id