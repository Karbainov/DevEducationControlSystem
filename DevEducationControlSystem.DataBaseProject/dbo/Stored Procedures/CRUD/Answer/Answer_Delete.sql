CREATE PROCEDURE Answer_Delete 
    @ID int
    As
    DELETE Answer WHERE Answer.ID = @ID