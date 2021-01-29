CREATE PROCEDURE [dbo].[Course_Material_SelectById]
	@Id int
AS
	SELECT * FROM [dbo].[Course_Material] WHERE Id=@Id
GO