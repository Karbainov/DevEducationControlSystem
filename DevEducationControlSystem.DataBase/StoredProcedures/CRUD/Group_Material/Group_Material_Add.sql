CREATE PROCEDURE Group_Material_Add
	@ID int,	
	@GroupID int,
	@MaterialID int
AS
INSERT [Group_Material] VALUES (@ID,
	@GroupID,
	@MaterialID)
	go