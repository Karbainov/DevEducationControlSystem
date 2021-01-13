CREATE PROCEDURE [dbo].[Course_Material_SelectById]
	@Id int
AS
	SELECT * FROM Course_Material WHERE ID=@Id
GO