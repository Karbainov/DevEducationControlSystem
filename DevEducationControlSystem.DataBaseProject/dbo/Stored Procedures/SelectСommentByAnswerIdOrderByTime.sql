create Proc [dbo].[SelectСommentByAnswerIdOrderByTime]
@AnswerId int
AS
Select c.id, CONCAT (u.FirstName,' ', u.LastName) as FullName,c.Message,c.Date
From [User] u
join Answer a on u.Id = a.UserId
join Comment c on c.AnswerId = a.Id
where a.id = 2
Order by c.Date ASC
