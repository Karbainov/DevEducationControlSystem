CREATE PROCEDURE [dbo].[UserStatus_Update]
	@Id int,
	@Name nvarchar(100)
AS
UPDATE [dbo].[UserStatus]
	SET 
	Name = @Name
WHERE Id = @Id