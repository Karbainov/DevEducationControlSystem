CREATE PROCEDURE [dbo].[Comment_Delete]
    @Id int
    As
    DELETE [dbo].[Comment] WHERE [dbo].[Comment].Id = @Id