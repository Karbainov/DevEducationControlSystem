CREATE PROCEDURE GetMaterialsByThemeId @ThemeId int AS
SELECT  
	Theme.Id AS ThemeId, 
	Material.Id AS MaterialId, 
	Material.UserId AS UserId
FROM Theme
LEFT JOIN 
	Theme_Material ON Theme.Id=Theme_Material.ThemeId
LEFT JOIN 
	Material ON Theme_Material.MaterialId=Material.Id
INNER JOIN 
	[User] ON Material.UserId=[User].Id
WHERE Theme.Id=@ThemeId AND Material.IsDeleted='False'
GO;