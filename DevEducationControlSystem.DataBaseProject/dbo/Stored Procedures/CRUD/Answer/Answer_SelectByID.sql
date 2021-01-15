CREATE PROCEDURE Answer_SelectByID
    @ID int
    As
    SELECT * FROM Answer WHERE Answer.ID = @ID