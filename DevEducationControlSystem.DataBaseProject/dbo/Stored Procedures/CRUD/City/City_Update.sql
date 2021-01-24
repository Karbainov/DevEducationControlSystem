	CREATE PROCEDURE [dbo].[City_Update]  
	@Id int,	
	@Name nvarchar(100)
AS  
	UPDATE [dbo].[City] 
	SET
	[Name] = @Name
WHERE  
	Id=@Id