CREATE PROCEDURE [dbo].[Role_SelectById]
	@Id int 
AS
	SELECT * FROM [dbo].[Role] WHERE ID=@Id
