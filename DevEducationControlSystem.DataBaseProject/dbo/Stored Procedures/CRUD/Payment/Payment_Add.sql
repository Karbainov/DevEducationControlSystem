CREATE PROCEDURE [dbo].[Payment_Add]
@UserID int,
@GroupID int,
@Period int,
@Sum int,
@isPaid bit,
@PayDate date
AS
INSERT into [dbo].[Payment]
(UserId, GroupId, Period, isPaid, Summ, PayDate)
VALUES
(@UserID, @GroupID, @Period, @isPaid, @Sum, @PayDate)
