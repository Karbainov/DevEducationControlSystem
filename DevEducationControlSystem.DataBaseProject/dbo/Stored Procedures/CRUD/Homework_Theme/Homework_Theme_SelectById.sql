CREATE PROCEDURE [dbo].[Homework_Theme_SelectById]
@Id INT
AS
select * from dbo.Homework_Theme
where dbo.Homework_Theme.Id = @Id
