 CREATE PROCEDURE [dbo].[Resource_Delete]
    @Id int
    As
    DELETE [dbo].[Resource] WHERE [dbo].[Resource].Id = @Id