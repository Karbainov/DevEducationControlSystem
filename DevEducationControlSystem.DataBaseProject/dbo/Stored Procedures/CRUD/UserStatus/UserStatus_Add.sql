CREATE PROCEDURE [dbo].[UserStatus_Add]
	@Name nvarchar(100)
AS
INSERT [dbo].[UserStatus] VALUES (@Name)