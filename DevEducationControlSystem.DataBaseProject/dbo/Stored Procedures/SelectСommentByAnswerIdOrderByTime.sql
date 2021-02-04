CREATE PROCEDURE [dbo].[SelectСommentByAnswerIdOrderByTime]
@AnswerId int
AS
Select *
From Comment
where AnswerId = @AnswerId
