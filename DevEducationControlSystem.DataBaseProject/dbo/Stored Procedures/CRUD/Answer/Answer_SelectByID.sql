CREATE PROCEDURE [dbo].[Answer_SelectById]
    @Id int
    As
    SELECT * FROM [dbo].[Answer] WHERE [dbo].[Answer].Id = @Id