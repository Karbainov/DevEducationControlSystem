CREATE PROCEDURE [dbo].[User_SelectById]
	@Id int 
AS 
	SELECT * FROM [dbo].[User] WHERE ID = @Id