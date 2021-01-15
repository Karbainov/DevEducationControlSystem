CREATE PROCEDURE Group_Material_Add
	@GroupID int,
	@MaterialID int
AS
INSERT [Group_Material] VALUES (@GroupID,
	@MaterialID)
	go