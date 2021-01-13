CREATE PROCEDURE Theme_Material_SelectById
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
SELECT @Id FROM Theme_Material WHERE ID=@Id 
