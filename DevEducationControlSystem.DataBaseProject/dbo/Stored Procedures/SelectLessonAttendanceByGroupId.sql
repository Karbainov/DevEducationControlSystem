CREATE PROCEDURE [dbo].[SelectLessonAttendanceByGroupId]
@groupId int
as
select L.Id as LessonId, L.Name as Lesson, L.LessonDate,
G.Id as GroupId, G.Name as [Group],
U.Id as UserId, U.FirstName, U.LastName, U.StatusId as UserStatus, A.IsPresent

from Attendance as A 
join [User] as U on U.Id = A.UserId
right join Lesson as L on L.Id = A.LessonId
join [Group] as G on G.Id =L.GroupId
where G.Id = @groupId