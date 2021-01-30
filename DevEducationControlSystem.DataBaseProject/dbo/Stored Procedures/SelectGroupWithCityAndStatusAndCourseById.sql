CREATE PROCEDURE [dbo].[SelectGroupWithCityAndStatusAndCourseById]
	@groupId int
AS
SELECT G.Id, G.Name, G.StartDate,
	GS.Id as StatusId, GS.Name as [Status],
	C.Id as CityId, C.Name as City,
	Crs.Id as CourseId, Crs.Name as Course
	from [Group] as G
	join [GroupStatus] as GS on G.StatusId=GS.Id
	join [City] as C on G.CityId=C.Id
	join [Course] as Crs on G.CourseId= Crs.Id
 	where G.Id=@groupId