CREATE PROCEDURE [dbo].[SelectNoStudentUsersWithRoleAndStatus]

AS

BEGIN
	select
	U.Id,
	U.FirstName,
	U.LastName,
	U.[Login],
	U.[Password],
	R.Name as Role,
	US.Name as Status

	From [User] U
	 join User_Role UR on U.Id=UR.UserId
	 join Role R on UR.RoleId=R.Id 
	 join UserStatus US on U.StatusId=US.Id
	where UR.RoleId<>2
	order by R.Name asc
END