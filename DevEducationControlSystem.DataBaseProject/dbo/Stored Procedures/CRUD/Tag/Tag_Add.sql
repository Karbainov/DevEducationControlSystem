CREATE PROCEDURE [dbo].[Tag_Add]
	@Name nvarchar(30)
AS
	Insert into dbo.Tag
	VAlues (@Name)
