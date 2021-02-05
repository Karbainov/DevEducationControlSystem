CREATE PROCEDURE [dbo].[GetTeachersStatistic]
	as
	select 
C.Id as CourseId,
G.Id as GroupId,
G.[Name] as GroupName,
U.Id as TeacherId,
concat (U.FirstName, ' ', U.LastName) as TeacherName
	from Course as C
	inner join [Group] as G on C.Id=G.CourseId
	inner join City as CT on G.CityId=CT.Id
	inner join User_Group as UG on G.Id=UG.GroupId
	inner join User_Role as UR on UG.UserId=UR.UserId
	inner join [User] as U on  U.Id = UR.UserId 
	where UR.RoleId = '1'
	group by C.Id, G.Id, G.[Name], U.Id, U.FirstName, U.LastName
	go
