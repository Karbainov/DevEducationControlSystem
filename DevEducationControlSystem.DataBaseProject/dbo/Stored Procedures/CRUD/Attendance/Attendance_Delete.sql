CREATE PROCEDURE [dbo].[Attendance_Delete]
	@Id int 
AS 
	DELETE FROM [dbo].[Attendance] WHERE Id=@Id
