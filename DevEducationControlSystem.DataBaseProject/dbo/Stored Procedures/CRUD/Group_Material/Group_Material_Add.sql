CREATE PROCEDURE [dbo].[Group_Material_Add]
	@GroupID int,
	@MaterialID int
AS
INSERT [dbo].[Group_Material] VALUES (@GroupID,
	@MaterialID)
	go