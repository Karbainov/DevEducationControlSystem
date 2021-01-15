CREATE PROCEDURE [dbo].[Theme_Material_Select]
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
SELECT * FROM [dbo].[Theme_Material]
