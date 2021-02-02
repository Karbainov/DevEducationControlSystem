CREATE PROCEDURE [dbo].[GetAllMaterialsByTag]
	@Tag nvarchar(100)
AS
	SELECT 
	Tag.Name AS TagName,
	Material.Id AS MaterialId, 
	Material.Name AS MaterialName,
	Material.Message AS MaterialMessage

FROM Material
LEFT JOIN 
	Material_Tag ON Material.Id=Material_Tag.MaterialId
LEFT JOIN 
	Tag ON Material_Tag.TagId=Tag.Id

WHERE Tag.Name=@Tag AND Material.isDeleted='False'
GO
