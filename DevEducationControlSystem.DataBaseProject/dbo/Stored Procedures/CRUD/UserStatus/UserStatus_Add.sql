CREATE PROCEDURE [dbo].[UserStatus_Add]
	@Name nvarchar(100)
AS
INSERT UserStatus VALUES (@Name)