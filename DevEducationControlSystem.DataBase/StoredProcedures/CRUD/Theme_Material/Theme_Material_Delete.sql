CREATE PROCEDURE Theme_Material_Delete
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
DELETE Theme_Material WHERE ID=@Id 

  