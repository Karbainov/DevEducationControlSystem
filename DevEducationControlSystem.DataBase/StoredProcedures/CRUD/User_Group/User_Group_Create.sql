CREATE PROCEDURE User_Group_Create 
	@UserId int, 
	@GroupId int
AS 

INSERT User_Group VALUES (@UserId, @GroupId)

