CREATE PROCEDURE [dbo].[City_SelectById] 
	@Id int 
AS 
	SELECT * FROM [dbo].[City] WHERE Id = @Id