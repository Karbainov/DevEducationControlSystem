CREATE PROCEDURE Privileges_Update  
	@Id int,  
	@name nvanchar(30)
AS  
	UPDATE Privileges 
	SET  
		name = @name
WHERE  
	ID=@Id