CREATE PROCEDURE [dbo].[Tag_SelectById]
	@ID int
AS
	SELECT * from dbo.Material_Tag
	where dbo.Material_Tag.ID=@ID
