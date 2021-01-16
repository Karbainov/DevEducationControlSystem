CREATE PROCEDURE [dbo].[Privileges_SelectById] 
	@Id int 
AS 
	SELECT * FROM [dbo].[Privileges] WhERE ID = @Id