CREATE PROCEDURE [dbo].[AddAnswerOnCurrentHomework]
	@Id int,
	@UserId int,
	@ResourceId int,
	@HomeWorkId int,
    @Message NVARCHAR(1000),
	@Links NVARCHAR(1000),
	@Images NVARCHAR(1000)
AS
UPDATE [dbo].[Answer] 
SET 
UserId = @UserId, 
[ResourceId] = @ResourceId,
[HomeworkId] = @HomeworkId,
[Date] = GETDATE(),
[Message] = @Message,
StatusId = 7
WHERE [dbo].[Answer].Id = @Id
UPDATE [dbo].[Resource] 
SET 
Links = @Links,
Images = @Images
WHERE [dbo].[Resource].Id = [dbo].[Answer].ResourceId