CREATE PROCEDURE [dbo].[Privileges_Update]  
	@Id int,  
	@name nvanchar(30)
AS  
	UPDATE [dbo].[Privileges] 
	SET  
		name = @name
WHERE  
	ID=@Id