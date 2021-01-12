CREATE PROCEDURE Role_Privileges_Update 
	@Id int, 
	@RoleId int, 
	@PrivilegesId int 
AS 
	UPDATE Role_Privileges
	SET 
		RoleID = @RoleId, 
		PrivilegesID = @PrivelegesId 
WHERE 
	ID=@Id