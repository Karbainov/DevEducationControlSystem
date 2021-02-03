CREATE PROCEDURE [dbo].[Answer_Add]
	@UserId int,
	@ResourceId int,
	@HomeWorkId int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusId int
AS
INSERT [dbo].[Answer] (UserId,ResourceId, [HomeworkId], [Date], [Message], StatusId)
VALUES(@UserId, @ResourceId, @HomeWorkId, @Date, @Message, @StatusId)
