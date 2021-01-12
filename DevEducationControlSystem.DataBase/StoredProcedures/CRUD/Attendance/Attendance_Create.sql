CREATE PROCEDURE Attendance_Create 
	@UserId int, 
	@LessonId int,
	@IsPresent bit
AS 
INSERT Attendance VALUES (@UserId, @LessonId, @IsPresent)
