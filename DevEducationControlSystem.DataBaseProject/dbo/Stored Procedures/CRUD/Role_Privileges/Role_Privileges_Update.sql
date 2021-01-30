CREATE PROCEDURE [dbo].[Role_Privileges_Update] 
	@Id int, 
	@RoleId int, 
	@PrivilegesId int 
AS 
	UPDATE [dbo].[Role_Privileges]
	SET 
	RoleId = @RoleId, 
	PrivilegesId = @PrivilegesId 
WHERE 
	Id = @Id