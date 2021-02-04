CREATE PROCEDURE [dbo].[Course_Delete]  
	@Id int   
AS   

BEGIN
	DELETE FROM dbo.Homework_Course where dbo.Homework_Course.CourseId=@Id
	DELETE FROM dbo.Course_Theme where dbo.Course_Theme.CourseId=@Id
	DELETE FROM dbo.Course_Material where dbo.Course_Material.CourseId=@Id

	declare @DeletedCourseId int
	set @DeletedCourseId = 7
	UPDATE dbo.[Group] SET CourseId = @DeletedCourseId where CourseId=@Id

	DELETE FROM dbo.Course where Id=@Id
END	
