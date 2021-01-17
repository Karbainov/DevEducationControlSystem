CREATE PROCEDURE [dbo].[Lesson_Theme_Delete]
@Id int
AS
DELETE from [dbo].[Payment]
WHERE Id = @Id