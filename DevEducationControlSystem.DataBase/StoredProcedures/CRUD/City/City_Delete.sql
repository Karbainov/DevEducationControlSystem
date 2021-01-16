CREATE PROCEDURE City_Delete  
	@Id int  
AS  
	DELETE FROM [City] WHERE ID = @Id