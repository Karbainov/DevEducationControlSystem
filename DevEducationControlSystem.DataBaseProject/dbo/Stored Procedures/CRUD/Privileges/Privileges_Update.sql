CREATE PROCEDURE [dbo].[Privileges_Update]  
	@Id int,  
	@name nvarchar(30)
AS  
	UPDATE [dbo].[Privileges] 
	SET  
	name = @name
WHERE  
	Id = @Id
