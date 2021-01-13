CREATE PROCEDURE Group_Homework_Delete
	@Id int
AS
	DELETE FROM Group_Homework WHERE ID=@Id
GO