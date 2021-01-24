CREATE PROCEDURE [dbo].[Theme_Tag_Update]
	@Id int,
	@ThemeId int,
	@TagId int
AS
	update Theme_Tag
	set @ThemeId=@ThemeId, TagId=@TagId
	WHERE Id=@Id