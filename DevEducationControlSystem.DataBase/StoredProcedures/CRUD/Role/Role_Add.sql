CREATE PROCEDURE Role_Add
	@Name nvarchar(30)
AS
	INSERT Role VALUES (@Name)
