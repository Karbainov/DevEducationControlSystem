CREATE PROCEDURE [dbo].[Payment_Add]
@UserId int,
@GroupId int,
@Period int,
@isPaid bit,
@Sum int,
@PayDate date
AS
INSERT into [dbo].[Payment]
(UserId, GroupId, [Period], isPaid, [Sum], PayDate)
VALUES
(@UserId, @GroupID, @Period, @isPaid, @Sum, @PayDate)
