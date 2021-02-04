CREATE PROCEDURE [dbo].[UpdateAttendanceIsPresent]
	@Id int,
	@IsPresent int
AS
	UPDATE [dbo].[Attendance]
	SET 
		IsPresent = @IsPresent
WHERE 
	Id=@Id
