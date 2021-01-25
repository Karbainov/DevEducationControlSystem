CREATE PROCEDURE [dbo].[Attendance_Update]
	@Id int, 
	@UserId int, 
	@LessonId int,
	@IsPresent bit 
AS 
	UPDATE [dbo].[Attendance]
	SET 
		UserId = @UserId, 
		LessonId = @LessonId,
		IsPresent = @IsPresent
WHERE 
	Id=@Id