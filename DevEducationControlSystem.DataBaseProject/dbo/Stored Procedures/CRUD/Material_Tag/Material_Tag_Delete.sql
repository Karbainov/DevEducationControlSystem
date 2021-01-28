CREATE PROCEDURE [dbo].[Material_Tag_Delete]
	@Id int
AS
	DELETE FROM dbo.Material_Tag
	WHERE Id=@Id
