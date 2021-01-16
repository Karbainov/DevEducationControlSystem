CREATE PROCEDURE [dbo].[Theme_Material_Add]
	@ThemeID int,
	@MaterialID int
AS
INSERT [dbo].[Theme_Material] VALUES (@ThemeID,@MaterialID)