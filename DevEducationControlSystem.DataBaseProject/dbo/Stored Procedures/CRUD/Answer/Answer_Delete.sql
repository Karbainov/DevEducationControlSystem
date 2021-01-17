CREATE PROCEDURE [dbo].[Answer_Delete]
    @Id int
    As
    DELETE [dbo].[Answer] WHERE [dbo].[Answer].Id = @Id