CREATE PROCEDURE [dbo].[MaterialTagDelete]
	@ID int
AS
	DELETE FROM dbo.Material_Tag
	WHERE ID=@ID
