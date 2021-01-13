CREATE PROCEDURE [dbo].[Course_Material_Add]
	@CourseId int,
	@MaterialId int
AS
INSERT [dbo].[Course_Material] VALUES (@CourseId, @MaterialId)