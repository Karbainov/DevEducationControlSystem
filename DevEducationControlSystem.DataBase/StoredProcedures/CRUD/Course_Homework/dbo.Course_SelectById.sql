CREATE PROCEDURE dbo.Course_SelectById
@ID INT
AS
select * from dbo.Course
where dbo.Course.ID = @ID
