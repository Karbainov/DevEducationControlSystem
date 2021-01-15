CREATE PROCEDURE AnswerStatus_Delete 
    @ID int
    As
    DELETE AnswerStatus WHERE AnswerStatus.ID = @ID