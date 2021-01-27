CREATE PROCEDURE [dbo].[SelectHomeworkWithStatusesByUserId]
	@UserId int
AS
select 
	H.Name HomeworkName,
	Ast.Name HomeworkStatus,
	H.Description,
	R.Links,
	R.Images,
	a.Date AnswerDate
from [Answer] A
right join [AnswerStatus] ASt on ASt.Id = A.StatusId
join [Homework] H on H.Id = A.HomeworkId
join [Resource] R on r.Id = h.ResourceId
where A.UserId = @UserId
