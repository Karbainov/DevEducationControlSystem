CREATE PROCEDURE Course_Theme_ReadById
	@Id int
AS
	SELECT * FROM Course_Theme WHERE ID=@Id
