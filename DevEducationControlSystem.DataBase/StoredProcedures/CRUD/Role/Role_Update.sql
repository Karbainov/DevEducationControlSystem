CREATE PROCEDURE [dbo].[Role_Update]
	@Id int ,
	@Name nvarchar(30)
AS
	UPDATE Role 
	SET Name=@Name WHERE ID=@Id
