CREATE PROCEDURE [dbo].[City_Delete]  
	@Id int  
AS  
	DELETE FROM [dbo].[City] WHERE Id = @Id