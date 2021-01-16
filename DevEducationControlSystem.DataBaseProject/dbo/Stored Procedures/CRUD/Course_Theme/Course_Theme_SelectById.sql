CREATE PROCEDURE [dbo].[Course_Theme_SelectById]
	@Id int
AS
	SELECT * FROM [dbo].[Course_Theme] WHERE ID=@Id
