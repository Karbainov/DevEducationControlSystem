CREATE PROCEDURE [dbo].[Theme_Tag_SelectById]
	@ID int
AS
	SELECT * from dbo.Theme_Tag
	where dbo.Theme_Tag.ID=@ID
