CREATE PROCEDURE [dbo].[SelectNumberOfStudentsByTeacherId]
		@UserId int
AS
select G.Id as GroupId, G.Name as GroupName, NumberOfStudents from [Group] as G inner join
(select GROUPS.GroupId, COUNT(U.Id) as NumberOfStudents from [User] as U 
inner join [User_Group] as UG on U.Id = UG.UserId 
inner join [Group] as G on UG.GroupId = G.Id
inner join [User_Role] as UR on U.Id = UR.UserId
inner join (select G.Id as GroupId, G.Name as GroupName from [User] as U 
	inner join [User_Group] as UG on U.Id = UG.UserId 
	inner join [Group] as G on UG.GroupId = G.Id where U.Id = @UserId) as GROUPS on GROUPS.GroupId = G.Id
where UR.RoleId = 2 Group by GROUPS.GroupId) as GU on G.Id = GU.GroupId