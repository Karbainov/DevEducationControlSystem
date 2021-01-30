CREATE PROCEDURE [dbo].[Tag_Delete]
	@Id int
AS
	DELETE FROM dbo.Tag
	WHERE Id=@Id
