CREATE PROCEDURE [dbo].[Attendance_SelectById] 
	@Id int 
AS 
	SELECT * FROM [dbo].[Attendance] WHERE ID=@Id 
