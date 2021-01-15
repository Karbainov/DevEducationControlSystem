CREATE PROCEDURE AnswerStatus_Add
    @Name NVARCHAR(100)
AS
INSERT AnswerStatus ([Name])
VALUES(@Name)