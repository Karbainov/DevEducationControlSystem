CREATE PROCEDURE [dbo].[Role_Privileges_Update] 
	@Id int, 
	@RoleId int, 
	@PrivilegesId int 
AS 
	UPDATE [dbo].[Role_Privileges]
	SET 
	RoleID = @RoleId, 
	PrivilegesID = @PrivilegesID 
WHERE 
	Id = @Id