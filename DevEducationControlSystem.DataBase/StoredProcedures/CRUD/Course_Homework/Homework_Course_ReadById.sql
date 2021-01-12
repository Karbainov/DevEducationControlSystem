CREATE PROCEDURE Homework_Course_ReadById 
	@Id int 
AS 
	SELECT * FROM Homework_Course WHERE ID=@Id 
