CREATE PROCEDURE Theme_Material_SelectById
	@ThemeID int,
	@MaterialID int,
	@Id int
AS
SELECT @Id FROM [dbo].[Theme_Material] WHERE Id=@Id 
