CREATE PROCEDURE [dbo].[Role_Privileges_Add]
	@UserID int,
	@PrivilegesID int
AS
INSERT [dbo].[Role_Privileges] VALUES (@UserID, @PrivilegesID)