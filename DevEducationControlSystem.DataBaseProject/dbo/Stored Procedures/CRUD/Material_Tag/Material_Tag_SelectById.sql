CREATE PROCEDURE [dbo].[Material_Tag_SelectById]
	@Id int
AS
	SELECT * from dbo.Material_Tag
	where dbo.Material_Tag.Id=@Id
