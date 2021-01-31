CREATE PROCEDURE [dbo].[Material_Tag_Update]
	@Id int,
	@MaterialId int,
	@TagId int
AS
	update Material_Tag
	set MaterialId=@MaterialId, TagId=@TagId
	WHERE Id=@Id
