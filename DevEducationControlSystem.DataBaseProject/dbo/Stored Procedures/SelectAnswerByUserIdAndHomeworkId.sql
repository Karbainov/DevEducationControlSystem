create Proc [dbo].[SelectAnswerByUserIdAndHomeworkId]
@UserId int,
@HomeworkId int
AS
Select a.Id as AnswerId,a.Message,a.Date, AnS.Name 
From [User] u
join Answer a on u.Id = a.UserId
join AnswerStatus AnS on AnS.Id = a.StatusId
join Homework h on a.HomeworkId = h.Id
 where u.Id = @UserId and h.Id = @HomeworkId
