CREATE PROCEDURE [dbo].[Course_SelectById]
@Id INT
AS
select * from dbo.Course
where dbo.Course.ID = @Id