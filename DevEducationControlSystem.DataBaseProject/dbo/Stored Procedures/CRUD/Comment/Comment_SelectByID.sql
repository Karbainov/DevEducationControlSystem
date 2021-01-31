CREATE PROCEDURE [dbo].[Comment_SelectById]
    @Id int
    As
    SELECT * FROM [dbo].[Comment] WHERE [dbo].[Comment].Id = @Id