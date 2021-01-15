CREATE PROCEDURE [dbo].[Group_Material_SelectById] 
	@Id int 
AS 
	SELECT * FROM [dbo].[Group_Material] WHERE Id = @Id
