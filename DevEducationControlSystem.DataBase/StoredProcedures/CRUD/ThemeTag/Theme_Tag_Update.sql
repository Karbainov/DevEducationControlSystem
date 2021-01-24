CREATE PROCEDURE [dbo].[Theme_Tag_Update]
	@ID int,
	@ThemeID int,
	@TagID int
AS
	update Theme_Tag
	set @ThemeID=@ThemeID, TagID=@TagID
	WHERE ID=@ID