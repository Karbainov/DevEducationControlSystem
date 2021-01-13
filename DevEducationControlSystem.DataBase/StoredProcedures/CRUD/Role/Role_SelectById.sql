CREATE PROCEDURE [dbo].[Role_SelectById]
	@Id int 
AS
	SELECT * FROM Role WHERE ID=@Id
