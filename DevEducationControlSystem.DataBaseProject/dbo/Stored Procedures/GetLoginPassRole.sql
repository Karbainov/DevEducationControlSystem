CREATE PROCEDURE [dbo].[GetLoginPassRole]
AS
	select 
        U.Id as UserId,
        U.Login as UserLog,
        U.Password as UserPas,
        [Role].Name as Role
    from [User] as U
        join User_Role on U.Id = User_Role.UserId
        join  [Role] on User_Role.RoleId = [Role].Id