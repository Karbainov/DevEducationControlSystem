﻿CREATE PROCEDURE [dbo].[Lesson_SelectById]
	@Id int
AS
	SELECT * FROM Lesson WHERE Id=@Id
GO