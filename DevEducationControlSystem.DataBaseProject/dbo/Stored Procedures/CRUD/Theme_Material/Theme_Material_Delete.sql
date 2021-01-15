CREATE PROCEDURE [dbo].[Theme_Material_Delete]
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
DELETE [dbo].[Theme_Material] WHERE Id=@Id 
