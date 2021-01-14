CREATE PROCEDURE [dbo].[Course_Material_Delete]
	@Id int
AS
	DELETE FROM [dbo].[Course_Material] WHERE ID=@Id
GO