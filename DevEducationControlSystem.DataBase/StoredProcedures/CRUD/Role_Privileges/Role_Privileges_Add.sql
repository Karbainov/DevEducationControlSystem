CREATE PROCEDURE [dbo].[Role_Privileges_Add]
	@RoleID int,
	@PrivilegesID int
AS
INSERT [dbo].[Role_Privileges] VALUES (@RoleID, @PrivilegesID)