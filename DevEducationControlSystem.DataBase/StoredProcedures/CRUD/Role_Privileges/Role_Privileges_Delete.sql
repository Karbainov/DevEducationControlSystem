CREATE PROCEDURE Role_Privileges_Delete 
	@Id int 
AS 
	DELETE FROM Role_Privilegese WHERE ID = @Id