CREATE PROCEDURE Course_Material_ReadById
	@Id int
AS
	SELECT * FROM Course_Material WHERE ID=@Id
GO