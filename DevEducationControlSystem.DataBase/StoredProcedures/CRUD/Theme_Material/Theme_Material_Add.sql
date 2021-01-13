CREATE PROCEDURE Theme_Material_Add
	@ThemeID int,
	@MaterialID int
AS
INSERT Theme_Material VALUES (@ThemeID,@MaterialID)
