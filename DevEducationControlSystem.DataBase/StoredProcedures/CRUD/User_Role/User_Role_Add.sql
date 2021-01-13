CREATE PROCEDURE [dbo].[User_Role_Add]
	@UserId int ,
	@RoleId int
AS
	INSERT User_Role VALUES (@UserId, @RoleId)