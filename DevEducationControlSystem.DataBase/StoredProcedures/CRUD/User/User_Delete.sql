CREATE PROCEDURE User_Delete  
	@Id int
AS  
	DELETE FROM [User] WHERE ID = @Id