CREATE PROCEDURE [dbo].[Theme_SelectById] 
	@Id int 
AS 
	SELECT * FROM [Theme] WHERE ID = @Id