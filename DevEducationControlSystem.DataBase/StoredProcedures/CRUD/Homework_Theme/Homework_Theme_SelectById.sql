CREATE PROCEDURE [dbo].[Homework_Theme_SelectById]
@ID INT
AS
select * from dbo.Homework_Theme
where dbo.Homework_Theme.ID = @ID
