CREATE PROCEDURE [dbo].[SelectLessonAttendanceByGroupId]
@groupId int
as
select L.Id as LessonId, L.Name as Lesson, L.LessonDate,
G.Id as GroupId, G.Name as [Group],
A.Id,A.UserId, A.IsPresent

from Attendance as A 
right join Lesson as L on L.Id = A.LessonId
join [Group] as G on G.Id =L.GroupId
where G.Id = @groupId