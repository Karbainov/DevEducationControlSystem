CREATE PROCEDURE UserStatus_Update
	@Id int,
	@Name nvarchar(100)
AS
UPDATE UserStatus 
	SET 
	Name = @Name
WHERE ID = @Id