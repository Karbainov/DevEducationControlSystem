CREATE PROCEDURE Privileges_Delete  
	@Id int  
AS  
	DELETE FROM Privileges WHERE ID = @Id