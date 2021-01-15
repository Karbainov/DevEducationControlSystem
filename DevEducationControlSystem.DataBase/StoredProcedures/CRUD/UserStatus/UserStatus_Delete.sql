CREATE PROCEDURE UserStatus_Delete 
	@Id int 
AS 
	DELETE FROM UserStatus WHERE ID=@Id