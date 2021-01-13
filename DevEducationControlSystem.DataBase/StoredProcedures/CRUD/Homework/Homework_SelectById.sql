CREATE PROCEDURE [dbo].[Homework_SelectById]
@ID INT
AS
select * from dbo.Homework
where dbo.Homework.ID = @ID