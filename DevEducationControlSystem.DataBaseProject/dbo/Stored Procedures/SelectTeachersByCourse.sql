CREATE PROCEDURE [dbo].[SelectTeachersByCourse]
as
select C.Id as CourseId, C.[Name] as [Name], G.CityId as CityId, CT.[Name] as CityName, count (C.Id) as Amount
	from Course as C
	inner join [Group] as G on C.Id=G.CourseId
	inner join City as CT on G.CityId=CT.Id
	inner join User_Group as UG on G.Id=UG.GroupId
	inner join User_Role as UR on UG.UserId=UR.UserId
	where UR.RoleId = '1'
	group by C.Id, C.[Name], G.CityId, CT.[Name]
	go
