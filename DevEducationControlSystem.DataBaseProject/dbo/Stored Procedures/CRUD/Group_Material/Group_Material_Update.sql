CREATE PROCEDURE [dbo].[Group_Material_Update]  
	@Id int,	
	@GroupID int,
	@MaterialID int
AS  
	UPDATE [dbo].[Group_Material] 
	SET
	[GroupID] = @GroupID,
	[MaterialID] = @MaterialID
WHERE  
	Id=@Id