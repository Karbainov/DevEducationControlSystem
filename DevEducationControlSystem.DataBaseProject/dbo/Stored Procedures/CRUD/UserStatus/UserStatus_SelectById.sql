CREATE PROCEDURE [dbo].[UserStatus_SelectById]
	@Id int 
AS 
	SELECT * FROM [dbo].[UserStatus] WHERE Id = @Id