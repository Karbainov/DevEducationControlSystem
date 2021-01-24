CREATE PROCEDURE[dbo] . [Attendance_Add] 
	@UserId int, 
	@LessonId int,
	@IsPresent bit
AS 
INSERT [dbo].[Attendance] (UserId, LessonId, IsPresent)
VALUES (@UserId, @LessonId, @IsPresent)
