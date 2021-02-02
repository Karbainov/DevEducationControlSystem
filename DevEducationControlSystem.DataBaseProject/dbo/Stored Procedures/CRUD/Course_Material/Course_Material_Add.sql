CREATE PROCEDURE [dbo].[Course_Material_Add]
	@CourseId int,
	@MaterialId int
AS
INSERT INTO [dbo].[Course_Material] (CourseId, MaterialId) VALUES (@CourseId, @MaterialId)