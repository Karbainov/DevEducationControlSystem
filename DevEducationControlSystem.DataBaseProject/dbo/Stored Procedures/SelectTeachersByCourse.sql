CREATE PROCEDURE [dbo].[SelectTeachersByCourse]
	@CourseId int
as
select C.Id as CourseId, C.[Name] as [Name], G.CityId as CityId, CT.[Name] as CityName
	from Course as C
	inner join [Group] as G on C.Id=G.CourseId
	inner join City as CT on G.CityId=CT.Id
	inner join User_Group as UG on G.Id=UG.GroupId
	inner join User_Role as UR on UG.UserId=UR.UserId
	where G.CourseId = @CourseId
	and UR.RoleId = '1'
	go
