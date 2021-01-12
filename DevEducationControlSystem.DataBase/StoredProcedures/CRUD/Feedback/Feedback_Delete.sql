CREATE PROCEDURE Feedback_Delete 
	@Id int 
AS 
	DELETE FROM Feedback WHERE ID=@Id
