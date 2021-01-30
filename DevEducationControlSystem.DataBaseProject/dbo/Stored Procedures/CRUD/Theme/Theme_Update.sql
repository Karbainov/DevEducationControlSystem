CREATE PROCEDURE [dbo].[Theme_Update]
	@Id int ,
	@Name nvarchar(255)
AS
	UPDATE [Theme]
	SET Name = @Name WHERE Id=@Id