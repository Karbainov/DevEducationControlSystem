CREATE PROCEDURE Theme_Material_Update
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
UPDATE Theme_Material SET ThemeID = @ThemeID, MaterialID = @MaterialID  WHERE ID=@Id

