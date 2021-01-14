CREATE PROCEDURE [dbo].[User_Role_SelectById]
	@Id int
AS
	SELECT * FROM [dbo].[User_Role] WHERE ID=@Id