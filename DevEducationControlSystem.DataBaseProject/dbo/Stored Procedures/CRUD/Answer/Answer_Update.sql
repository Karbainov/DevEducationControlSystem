CREATE PROCEDURE [dbo].[Answer_Update]
	@Id int,
	@UserId int,
	@HomeworkId int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusId int
AS
UPDATE [dbo].[Answer] 
SET 
UserId = @UserId, 
[HomeworkId] = @HomeworkId,
[Date] = @Date,
[Message] = @Message,
StatusId = @StatusId
WHERE [dbo].[Answer].Id = @Id