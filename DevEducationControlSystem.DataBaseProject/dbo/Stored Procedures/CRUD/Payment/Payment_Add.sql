CREATE PROCEDURE [dbo].[Payment_Add]
@UserID int,
@GroupID int,
@Period int,
@isPaid bit,
@Sum int,
@PayDate date
AS
INSERT into [dbo].[Payment]
(UserId, GroupId, [Period], isPaid, [Sum], PayDate)
VALUES
(@UserID, @GroupID, @Period, @isPaid, @Sum, @PayDate)
