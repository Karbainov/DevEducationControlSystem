CREATE PROCEDURE Attendance_Update 
	@Id int, 
	@UserId int, 
	@LessonId int,
	@IsPresent bit 
AS 
	UPDATE Attendance
	SET 
		UserId = @UserId, 
		LessonId = @LessonId,
		IsPresent = @IsPresent
WHERE 
	ID=@Id