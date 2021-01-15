CREATE PROCEDURE [dbo].[Role_Privileges_Add]
	@Id int,
	@RoleID int,
	@PrivilegesID int
AS
INSERT [dbo].[Role_Privileges] VALUES (@Id ,@RoleID, @PrivilegesID)