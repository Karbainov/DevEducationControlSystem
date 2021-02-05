CREATE PROCEDURE [dbo].[Material_Delete]
	@Id int
AS  
BEGIN
	DELETE FROM dbo.Group_Material where dbo.Group_Material.MaterialId=@Id
	DELETE FROM dbo.Course_Material where dbo.Course_Material.MaterialId=@Id
	DELETE FROM dbo.Theme_Material where dbo.Theme_Material.MaterialId=@Id
	DELETE FROM dbo.Material_Tag where dbo.Material_Tag.MaterialId=@Id
	DELETE FROM dbo.Material where Id=@Id
END	
