CREATE PROCEDURE [dbo].[Comment_Add]
    @UserId int,
    @AnswerId int,
    @ResourceId int,
    @Date datetime,
    @Message NVARCHAR(1000)
AS
INSERT [dbo].[Comment] ([UserId], [AnswerId], [ResourceId], [Date], [Message])
VALUES (@UserId, @AnswerId, @ResourceId, @Date, @Message)