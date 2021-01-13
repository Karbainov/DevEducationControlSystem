CREATE PROCEDURE [dbo].[Course_Material_Add]
	@CourseId int,
	@MaterialId int
AS
INSERT Course_Material VALUES (@CourseId, @MaterialId)