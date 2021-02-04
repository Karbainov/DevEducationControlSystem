create Proc [dbo].[SelectAnswerAndStatusAnswerById]
@AnswerId int
AS
Select a.Id, a.UserId, a.ResourceId,r.Images, r.Links, a.HomeworkId, a.Date, a.Message, a.StatusId, AnS.Name
From Answer a
left join [Resource] r on r.Id = a.ResourceId
join AnswerStatus AnS on AnS.Id = a.StatusId
where a.Id = @AnswerId
