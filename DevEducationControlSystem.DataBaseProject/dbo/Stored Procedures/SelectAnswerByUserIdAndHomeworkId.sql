create Proc [dbo].[SelectAnswerByUserIdAndHomeworkId]
@UserId int,
@HomeworkId int
AS
Select a.Id as AnswerId,a.Message,a.Date, AnS.Name, r.Links, r.Images 
From [User] u
join Answer a on u.Id = a.UserId
join AnswerStatus AnS on AnS.Id = a.StatusId
join Homework h on a.HomeworkId = h.Id
join [Resource] r on r.Id = a.ResourceId
 where u.Id = @UserId and h.Id = @HomeworkId
