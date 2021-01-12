CREATE PROCEDURE Role_Create
	@Name nvarchar(30)
AS
	INSERT Role VALUES (@Name)
