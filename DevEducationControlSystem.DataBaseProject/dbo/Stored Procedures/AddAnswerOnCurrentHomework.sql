CREATE PROCEDURE [dbo].[AddAnswerOnCurrentHomework]
	@UserId int,
	@ResourceId int,
	@HomeWorkId int,
    @Message NVARCHAR(1000),
	@Links NVARCHAR(1000),
	@Images NVARCHAR(1000)
AS
INSERT [dbo].[Answer] (UserId, ResourceId, [HomeworkId], [StatusId],[Date], [Message])
VALUES(@UserId, @ResourceId, @HomeWorkId,7, GETDATE(), @Message)
INSERT [dbo].[Resource] (Links, Images)
VALUES(@Links, @Images)