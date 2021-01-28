﻿CREATE PROCEDURE [dbo].[Course_Material_Update]
	@Id int,
	@CourseId int,
	@MaterialId int
AS
	UPDATE [dbo].[Course_Material]
	SET
		CourseId = @CourseId,
		MaterialId = @MaterialId
WHERE
	Id=@Id