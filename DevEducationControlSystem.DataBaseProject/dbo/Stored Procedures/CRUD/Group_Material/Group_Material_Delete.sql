CREATE PROCEDURE [dbo].[Group_Material_Delete]  
	@Id int  
AS  
	DELETE FROM [dbo].[Group_Material] WHERE Id = @Id
