CREATE PROCEDURE Attendance_ReadById 
	@Id int 
AS 
	SELECT * FROM Attendance WHERE ID=@Id 
