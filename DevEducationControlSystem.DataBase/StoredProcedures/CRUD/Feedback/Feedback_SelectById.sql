CREATE PROCEDURE [dbo] . [Feedback_SelectById] 
	@Id int 
AS 
	SELECT * FROM [dbo] . [Feedback] WHERE ID=@Id 
