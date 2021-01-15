CREATE PROCEDURE [dbo].[Material_Tag_Add]
	@MaterialID int,
	@TagID int
AS
	Insert into dbo.Material_Tag
	VAlues (@MaterialID,@TagID)
