CREATE PROCEDURE [dbo].[Answer_Update]
	@Id int,
	@UserId int,
	@ResourceId int,
	@HomeworkId int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusId int
AS
UPDATE [dbo].[Answer] 
SET 
UserId = @UserId, 
[ResourceId] = @ResourceId,
[HomeworkId] = @HomeworkId,
[Date] = @Date,
[Message] = @Message,
StatusId = @StatusId
WHERE [dbo].[Answer].Id = @Id