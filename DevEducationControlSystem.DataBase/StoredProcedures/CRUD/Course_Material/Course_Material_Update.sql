CREATE PROCEDURE Course_Material_Update
	@Id int,
	@CourseId int,
	@MaterialId int
AS
	UPDATE Course_Material
	SET
		CourseId = @CourseId,
		MaterialID = @MaterialId
WHERE
	ID=@Id