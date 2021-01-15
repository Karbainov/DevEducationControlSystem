CREATE PROCEDURE [dbo].[Group_Delete] 
	@Id int  
AS  
	DELETE FROM [dbo].[Group] WHERE Id = @Id