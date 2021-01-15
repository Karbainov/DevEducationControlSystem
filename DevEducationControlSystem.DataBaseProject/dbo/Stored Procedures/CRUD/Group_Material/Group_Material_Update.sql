CREATE PROCEDURE Group_Material_Update  
	@Id int,	
	@GroupID int,
	@MaterialID int
AS  
	UPDATE [Group_Material] 
	SET
	[GroupID] = @GroupID,
	[MaterialID] = @MaterialID
WHERE  
	Id=@Id