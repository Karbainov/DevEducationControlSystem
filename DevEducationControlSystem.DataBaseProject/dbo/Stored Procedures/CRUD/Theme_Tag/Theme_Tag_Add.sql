CREATE PROCEDURE [dbo].[Theme_Tag_Add]
	@ThemeId int,
	@TagId int
AS
	INSERT Theme_Tag
	Values (@ThemeId,@TagId)