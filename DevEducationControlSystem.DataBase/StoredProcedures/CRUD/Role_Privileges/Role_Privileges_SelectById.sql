CREATE PROCEDURE [dbo].[Role_Privileges_SelectById]
	@Id int
AS
	SELECT * FROM [dbo].[Role_Privileges] WERE ID = @Id