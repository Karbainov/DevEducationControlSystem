CREATE PROCEDURE [dbo].[Role_Privileges_Add]
	@RoleId int,
	@PrivilegesId int
AS
INSERT [dbo].[Role_Privileges] VALUES (@RoleId, @PrivilegesId)