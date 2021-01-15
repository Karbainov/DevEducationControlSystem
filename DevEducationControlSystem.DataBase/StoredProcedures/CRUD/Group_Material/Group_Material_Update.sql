CREATE PROCEDURE Group_Material_Update  
	@ID int,	
	@GroupID int,
	@MaterialID int
AS  
	UPDATE [Group_Material] 
	SET
	[GroupID] = @GroupID,
	[MaterialID] = @MaterialID
WHERE  
	ID=@Id