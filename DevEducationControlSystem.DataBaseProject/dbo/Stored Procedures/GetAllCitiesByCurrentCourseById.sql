CREATE PROCEDURE [dbo].[GetAllCitiesByCurrentCourseById]
	@CourseId int
AS
	SELECT CT.Id AS CityId, CT.Name AS City FROM [dbo].[Course] AS C
	join [dbo].[Group] AS G on G.CourseId = C.Id
	join [dbo].[City] AS CT on CT.Id = G.CityId
	WHERE C.Id = @CourseId 