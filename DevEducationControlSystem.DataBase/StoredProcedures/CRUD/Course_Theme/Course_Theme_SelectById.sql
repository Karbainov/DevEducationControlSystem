CREATE PROCEDURE [dbo].[Course_Theme_SelectById]
	@Id int
AS
	SELECT * FROM Course_Theme WHERE ID=@Id
