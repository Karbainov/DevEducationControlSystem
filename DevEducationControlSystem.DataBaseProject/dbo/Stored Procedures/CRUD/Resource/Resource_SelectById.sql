CREATE PROCEDURE [dbo].[Resource_SelectById]
    @Id int
As
SELECT * FROM [dbo].[Resource] WHERE [dbo].[Resource].Id = @Id