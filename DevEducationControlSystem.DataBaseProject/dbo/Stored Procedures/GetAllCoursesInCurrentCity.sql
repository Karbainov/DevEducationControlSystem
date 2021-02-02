CREATE PROCEDURE [dbo].[GetAllCoursesInCurrentCity]
	@CityId int
AS
	SELECT C.Id AS CourseId,C.Name AS Course,CT.Name As City FROM [dbo].[City] AS CT
	join [dbo].[Group] AS G on G.CityId = CT.Id
	join [dbo].[Course] AS C on C.Id = G.CourseId
	WHERE CT.Id = @CityId 
