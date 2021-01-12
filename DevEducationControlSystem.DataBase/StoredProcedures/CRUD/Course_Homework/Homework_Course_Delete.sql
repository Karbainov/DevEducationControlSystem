CREATE PROCEDURE Homework_Course_Delete 
	@Id int 
AS 
	DELETE FROM Homework_Course WHERE ID=@Id
