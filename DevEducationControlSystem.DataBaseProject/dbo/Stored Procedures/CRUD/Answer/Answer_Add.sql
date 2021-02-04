CREATE PROCEDURE [dbo].[Answer_Add]
	@UserId int,
	@ResourceId int,
	@HomeworkId int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusId int
AS
INSERT [dbo].[Answer] (UserId,ResourceId, [HomeworkId], [Date], [Message], StatusId)
VALUES(@UserId, @ResourceId, @HomeworkId, @Date, @Message, @StatusId)
