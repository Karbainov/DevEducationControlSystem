CREATE PROCEDURE [dbo].[Answer_Add]
	@UserId int,
	@HomeWorkId int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusId int
AS
INSERT [dbo].[Answer] (UserId, [HomeworkId], [Date], [Message], StatusId)
VALUES(@UserId, @HomeWorkId, @Date, @Message, @StatusId)
