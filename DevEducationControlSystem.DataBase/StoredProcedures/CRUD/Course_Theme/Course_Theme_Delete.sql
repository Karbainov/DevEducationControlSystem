CREATE PROCEDURE Course_Theme_Delete
	@Id int
AS
	DELETE FROM Course_Theme WHERE ID=@Id