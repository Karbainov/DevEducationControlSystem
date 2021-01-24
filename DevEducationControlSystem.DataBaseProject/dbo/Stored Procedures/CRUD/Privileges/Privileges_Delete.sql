CREATE PROCEDURE [dbo].[Privileges_Delete]  
	@Id int  
AS  
	DELETE FROM [dbo].[Privileges] WHERE Id = @Id