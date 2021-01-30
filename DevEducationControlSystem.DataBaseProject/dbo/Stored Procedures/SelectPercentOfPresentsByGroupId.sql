CREATE PROCEDURE [dbo].[SelectPercentOfPresentsByGroupId]
	@GroupId int
AS
select STUD.UserId, STUD.FirstName, STUD.LastName, STUD.StatusId, US.Name as Status,  COALESCE(PRES.PercentOfPresents,0) as PercentOfPresents  from [Group] as G 
full join 
(select U.Id as [UserId], U.FirstName, U.LastName,U.StatusId, G.Id as Group_Id from [User] as U 
	left join User_Group as UG on U.Id = UG.UserId 
	full join [Group] as G on G.Id = UG.GroupId
	inner join User_Role as UR on UR.UserId = U.Id 
	where UR.RoleId = 2) as STUD on STUD.Group_Id = G.Id
	inner join UserStatus as US on STUD.StatusId = US.Id
full join 
(select A.UserId, CAST(COUNT(A.LessonId) as float) / 
	(select COUNT(L.Id) as AmountLessons from Lesson as L where GroupId = @GroupId) as PercentOfPresents from Attendance as A 	
	where A.IsPresent = 1 Group by A.UserId) as PRES on PRES.UserId = STUD.UserId 
where G.Id = @GroupId