CREATE PROCEDURE [dbo].[Theme_Tag_Delete]
	@Id int
AS
	DELETE FROM dbo.Theme_Tag
	WHERE Id=@Id
