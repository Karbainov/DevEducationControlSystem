CREATE PROCEDURE [dbo].[Theme_Material_Update]
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
UPDATE [dbo].[Theme_Material] SET ThemeId = @ThemeID, MaterialId = @MaterialID  WHERE Id=@Id
