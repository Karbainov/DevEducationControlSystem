create Proc [dbo].[SelectСommentByAnswerIdOrderByTime]
@AnswerId int
AS
Select c.Id, c.UserId,u.FirstName, u.LastName, c.AnswerId, c.ResourceId, c.Date, c.Message 
From Comment c
join [User] u on c.UserId = u.Id
where AnswerId = @AnswerId
Order by c.Date ASC
