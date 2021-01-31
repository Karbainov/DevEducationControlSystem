CREATE PROCEDURE [dbo].[ReplaceUserToAnotherGroupByUserId]
	@UserId int,
	@GroupId int
AS
	UPDATE User_Group SET UserId=@UserId, GroupId=@GroupId WHERE UserId=@UserId
