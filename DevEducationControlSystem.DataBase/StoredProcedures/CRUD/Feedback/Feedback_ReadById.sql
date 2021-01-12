CREATE PROCEDURE Feedback_ReadById 
	@Id int 
AS 
	SELECT * FROM Feedback WHERE ID=@Id 
