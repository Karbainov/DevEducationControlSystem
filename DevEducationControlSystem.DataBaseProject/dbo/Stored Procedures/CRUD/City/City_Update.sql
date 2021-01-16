	CREATE PROCEDURE [dbo].[City_Update]  
	@Id int,	
	@Name nvarchar(100)
AS  
	UPDATE [dbo].[Group] 
	SET
	[Name] = @Name
WHERE  
	Id=@Id