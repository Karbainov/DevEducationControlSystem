CREATE PROCEDURE [dbo].[Material_Tag_Delete]
	@ID int
AS
	DELETE FROM dbo.Material_Tag
	WHERE ID=@ID
