	CREATE PROCEDURE City_Update  
	@ID int,	
	@Name nvarchar(100)
AS  
	UPDATE [Group] 
	SET
	[Name] = @Name
WHERE  
	ID=@Id