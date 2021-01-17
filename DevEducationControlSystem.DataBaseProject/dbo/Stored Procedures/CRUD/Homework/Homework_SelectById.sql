CREATE PROCEDURE [dbo].[Homework_SelectById]
@Id INT
AS
select * from dbo.Homework
where dbo.Homework.Id = @Id