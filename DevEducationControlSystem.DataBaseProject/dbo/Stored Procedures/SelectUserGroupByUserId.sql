CREATE PROCEDURE [dbo].[SelectUserGroupByUserId]
	@UserId int
AS
	select * from User_Group as UG
where UG.UserId =@UserId
