CREATE PROCEDURE SelectHomeWorksAndAnswersByUserId
@UserId INT
AS
BEGIN

SELECT * FROM
Answer JOIN Homework ON Answer.HomeworkId=Homework.Id
WHERE
UserId = @UserId

END