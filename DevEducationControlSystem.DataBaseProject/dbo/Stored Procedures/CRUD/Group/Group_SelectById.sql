CREATE PROCEDURE [dbo].[Group_SelectById]
	@Id int 
AS 
	SELECT * FROM [dbo].[Group] WHERE Id = @Id