CREATE PROCEDURE [dbo].[MaterialTagCreate]
	@MaterialID int,
	@TagID int
AS
	Insert into dbo.Material_Tag
	VAlues (@MaterialID,@TagID)
