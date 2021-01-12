CREATE PROCEDURE Attendance_Delete 
	@Id int 
AS 
	DELETE FROM Attendance WHERE ID=@Id
