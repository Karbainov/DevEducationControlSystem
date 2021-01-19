CREATE PROCEDURE [dbo].[SelectHomeworksAndFeedbackByUserId]
	@UserId int
AS
select U.Id as UserId, 
	U.FirstName,
	U.LastName,
	L.Id as LessonId,
	L.Name as LessonName,
	A.IsPresent,
	F.Message as Feedback,
	F.Rate,
	L.LessonDate  
from Attendance as A 
inner join [User] as U on A.UserId = U.Id
inner join Lesson as L on A.LessonId = L.Id
left join Feedback as F on F.LessonId = L.Id and F.UserId = U.Id
where U.Id = @UserId