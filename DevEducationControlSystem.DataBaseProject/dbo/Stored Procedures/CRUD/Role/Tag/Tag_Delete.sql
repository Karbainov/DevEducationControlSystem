CREATE PROCEDURE [dbo].[Tag_Delete]
	@ID int
AS
	DELETE FROM dbo.Tag
	WHERE ID=@ID
