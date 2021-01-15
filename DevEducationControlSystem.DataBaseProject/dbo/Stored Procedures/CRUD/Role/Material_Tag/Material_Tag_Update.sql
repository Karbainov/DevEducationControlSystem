CREATE PROCEDURE [dbo].[Material_Tag_Update]
	@ID int,
	@MaterialID int,
	@TagID int
AS
	update Material_Tag
	set MaterialId=@MaterialID, TagID=@TagID
	WHERE ID=@ID
