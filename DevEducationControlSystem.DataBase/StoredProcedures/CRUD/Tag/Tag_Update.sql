CREATE PROCEDURE [dbo].[Tag_Update]
	@Id int,
	@Name nvarchar(30)
AS
	update Tag
	set Name=@Name
	WHERE ID=@Id
