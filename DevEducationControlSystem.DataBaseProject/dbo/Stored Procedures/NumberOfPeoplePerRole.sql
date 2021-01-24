CREATE PROCEDURE [dbo].[NumberOfPeoplePerRole]
	@RoleId int
AS
select COUNT(User_Role.Id) From [Role]
join [User_Role]  on [User_Role].RoleId = [Role].Id
where [Role].Id = @RoleId