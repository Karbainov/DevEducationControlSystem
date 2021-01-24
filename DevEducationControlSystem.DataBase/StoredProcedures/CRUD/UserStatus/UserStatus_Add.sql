CREATE PROCEDURE UserStatus_Add
	@Id int,
	@Name nvarchar(100)
AS
INSERT UserStatus VALUES (@Id,
	@Name)