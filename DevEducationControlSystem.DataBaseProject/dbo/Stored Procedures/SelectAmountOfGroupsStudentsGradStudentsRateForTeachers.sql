CREATE PROCEDURE [dbo].[SelectAmountOfGroupsStudentsGradStudentsRateForTeachers]

as
begin

declare @aos table (gId int, amount int, finish int)
insert into @aos 
select 
g.id as gid,
count( g.id) as amount,
count(case when us.id = 7 then 1 end) as finish
	from Course as C
	full join [Group] as G on C.Id=G.CourseId
	inner join User_Group as UG on G.Id=UG.GroupId
	inner join User_Role as UR on UG.UserId=UR.UserId
	inner join [User] as U on  U.Id = UR.UserId 
	full join UserStatus as US on U.StatusId = US.id
	where ur.RoleId = '2'
	group by  g.id

declare @rates table (groupId int, Rate int, UserStatus int, userId int, frate int)
insert into @rates
	select 
g.id as groupId,
F.Rate as Rate,
us.Id as UserStatus,
u.id as userId,
(select F.Rate where US.Id = '7') as frate
	from [Group] as G 
	inner join Lesson as L on G.Id = L.GroupId
	inner join User_Group as UG on G.Id=UG.GroupId
	inner join [User] as U on  U.Id = UG.UserId
	right outer join Feedback as F on U.Id = F.UserId
	inner join UserStatus as US on US.Id = U.StatusId
	group by  g.id, f.rate, us.id, u.id

select 
C.Id as CourseId,
G.Id as GroupId,
G.[Name] as GroupName,
U.Id as TeacherId,
concat (U.FirstName, ' ', U.LastName) as TeacherName,
count (distinct G.Id) as AmountOfGroups,
AOS.amount as AmountOfStudents,
AOS.finish as AmountOfStudentsFinished,
avg(R.Rate) as AllTimeRate, 
avg(R.frate) PostGradRate
	from Course as C
	inner join [Group] as G on C.Id=G.CourseId
	inner join City as CT on G.CityId=CT.Id
	inner join User_Group as UG on G.Id=UG.GroupId
	inner join User_Role as UR on UG.UserId=UR.UserId
	inner join [User] as U on  U.Id = UR.UserId 
	full join @aos as AOS on AOS.gId = G.Id
	full join @rates as R on R.groupId = G.Id
	where UR.RoleId = '1'
	group by C.Id, G.Id, G.[Name], U.Id, U.FirstName, U.LastName, AOS.amount, AOS.finish
	
end
