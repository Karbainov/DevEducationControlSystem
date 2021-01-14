CREATE PROCEDURE User_Group_Delete 
	@Id int 
AS 
	DELETE FROM User_Group WHERE ID=@Id
