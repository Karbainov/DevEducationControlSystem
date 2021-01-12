CREATE PROCEDURE Role_Privileges_Create
	@UserID int,
	@PrivilegesID int
AS
INSERT Role_Privileges VALUES (@UserID, @PrivilegesID)