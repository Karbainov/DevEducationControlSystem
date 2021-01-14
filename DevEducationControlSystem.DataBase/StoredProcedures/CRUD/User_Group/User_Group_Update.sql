CREATE PROCEDURE User_Group_Update 

	@Id int,
	@UserId int, 
	@GroupId int
AS 
	UPDATE  User_Group
	SET 
		UserId = @UserId, 
		GroupId = @GroupId
		
WHERE 
	ID=@Id
