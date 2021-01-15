CREATE PROCEDURE dbo.Homework_Course_SelectById 
	@Id int 
AS 
	SELECT * FROM Homework_Course WHERE ID=@Id 