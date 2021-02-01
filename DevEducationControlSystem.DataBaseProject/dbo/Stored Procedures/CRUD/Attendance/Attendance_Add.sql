﻿CREATE PROCEDURE[dbo] . [Attendance_Add] 
	@UserId int, 
	@LessonId int,
	@IsPresent bit
AS
INSERT [dbo].[Attendance] (UserId, LessonId, IsPresent)
output inserted.Id
VALUES (@UserId, @LessonId, @IsPresent)
