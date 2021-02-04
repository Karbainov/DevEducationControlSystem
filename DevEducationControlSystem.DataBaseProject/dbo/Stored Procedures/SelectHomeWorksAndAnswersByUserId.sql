CREATE PROCEDURE [dbo].[SelectHomeWorksAndAnswersByUserId]
@UserId INT
AS
BEGIN

SELECT  Homework.Id as HomeworkId, Answer.Id as AnswerId, Homework.ResourceId AS HWResourceId, Homework.[Name] as HWName, Homework.[Description] as HWDescript, Answer.ResourceId AS AnswerResourceId, Answer.[Message] AS AnswerMessage,  AnswerStatus.[Name] AS [AnswerStatus] FROM
Answer JOIN Homework ON Answer.HomeworkId=Homework.Id
JOIN
AnswerStatus ON Answer.StatusId=AnswerStatus.Id
WHERE
UserId = @UserId

END