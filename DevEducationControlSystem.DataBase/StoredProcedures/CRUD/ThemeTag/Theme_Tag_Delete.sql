CREATE PROCEDURE [dbo].[Theme_Tag_Delete]
	@ID int
AS
	DELETE FROM dbo.Theme_Tag
	WHERE ID=@ID