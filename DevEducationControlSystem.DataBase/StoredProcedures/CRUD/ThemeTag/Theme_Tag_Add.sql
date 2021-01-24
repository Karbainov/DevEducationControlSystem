CREATE PROCEDURE [dbo].[Theme_Tag_Add]
	@ThemeID int,
	@TagID int
AS
	Insert into dbo.Theme_Tag
	VAlues (@ThemeID,@TagID)