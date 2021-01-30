CREATE PROCEDURE [dbo] . [User_Group_Update] 

	@Id int,
	@UserId int, 
	@GroupId int
AS 
	UPDATE  [dbo] . [User_Group]
	SET 
		UserId = @UserId, 
		GroupId = @GroupId
		
WHERE 
	Id=@Id
