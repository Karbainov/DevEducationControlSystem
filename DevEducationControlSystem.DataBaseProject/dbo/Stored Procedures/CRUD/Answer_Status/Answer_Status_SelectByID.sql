CREATE PROCEDURE AnswerStatus_SelectByID
    @ID int
    As
    SELECT * FROM AnswerStatus WHERE AnswerStatus.ID = @ID