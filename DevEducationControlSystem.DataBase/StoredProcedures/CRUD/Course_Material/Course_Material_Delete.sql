CREATE PROCEDURE Course_Material_Delete
	@Id int
AS
	DELETE FROM Course_Material WHERE ID=@Id
GO