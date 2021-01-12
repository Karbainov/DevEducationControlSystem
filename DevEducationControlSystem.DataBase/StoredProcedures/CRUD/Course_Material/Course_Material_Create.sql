CREATE PROCEDURE Course_Material_Create
	@CourseId int,
	@MaterialId int
AS
INSERT Course_Material VALUES (@CourseId, @MaterialId)