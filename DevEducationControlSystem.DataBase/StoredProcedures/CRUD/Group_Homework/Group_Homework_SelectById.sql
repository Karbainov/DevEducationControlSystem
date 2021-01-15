CREATE PROCEDURE [dbo].[Group_Homework_SelectById]
	@Id int
AS
	SELECT * FROM Group_Homework WHERE ID=@Id
GO