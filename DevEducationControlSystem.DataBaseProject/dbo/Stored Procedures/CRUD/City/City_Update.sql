	CREATE PROCEDURE City_Update  
	@Id int,	
	@Name nvarchar(100)
AS  
	UPDATE [Group] 
	SET
	[Name] = @Name
WHERE  
	Id=@Id