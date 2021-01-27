CREATE PROCEDURE [dbo].[Comment_Update]
	@Id int,
	@UserId int,
    @AnswerId int,
    @ResourceId int,
    @Date datetime,
    @Message NVARCHAR(1000)
AS
UPDATE [dbo].[Comment] 
SET
UserId = @UserId, 
AnswerId = @AnswerId,
ResourceId = @ResourceId,
[Date] = @Date,
[Message] = @Message
WHERE [dbo].[Comment].Id = @Id