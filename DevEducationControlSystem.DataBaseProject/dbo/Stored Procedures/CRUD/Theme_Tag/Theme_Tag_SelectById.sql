CREATE PROCEDURE [dbo].[Theme_Tag_SelectById]
	@Id int
AS
	SELECT * from dbo.Theme_Tag
	where dbo.Theme_Tag.Id=@Id