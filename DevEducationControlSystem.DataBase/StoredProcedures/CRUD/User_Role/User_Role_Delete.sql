CREATE PROCEDURE [dbo].[User_Role_Delete]
	@Id int
AS
	DELETE FROM User_Role WHERE ID=@Id