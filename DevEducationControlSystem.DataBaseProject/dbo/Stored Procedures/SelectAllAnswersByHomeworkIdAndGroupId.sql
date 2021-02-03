CREATE PROCEDURE [dbo].[SelectAllAnswersByHomeworkIdAndGroupId]
	@HomeworkId int,
	@GroupId int
AS
	select A.Id as AnswerId, A.HomeworkId, A.Date, A.Message,
AnS.Id as StatusId, Ans.Name as Status,
U.Id as UserId, U.FirstName, U.LastName,
R.Id as ResourseId, R.Links, R.Images
from Answer as A
join Resource as R on A.ResourceId = R.Id
join AnswerStatus as AnS on A.StatusId = AnS.Id
join [User] as U on A.UserId = U.Id
join User_Group as UG on U.Id = UG.UserId
where A.HomeworkId = @HomeworkId and UG.GroupId = @GroupId