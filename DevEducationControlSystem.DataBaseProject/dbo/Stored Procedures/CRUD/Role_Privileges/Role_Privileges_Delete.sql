CREATE PROCEDURE [dbo].[Role_Privileges_Delete] 
	@Id int 
AS 
	DELETE FROM [dbo].[Role_Privileges] WHERE ID = @Id