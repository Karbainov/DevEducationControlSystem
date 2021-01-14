CREATE PROCEDURE [dbo].[Role_Update]
	@Id int ,
	@Name nvarchar(30)
AS
	UPDATE [dbo].[Role] 
	SET Name=@Name WHERE ID=@Id
