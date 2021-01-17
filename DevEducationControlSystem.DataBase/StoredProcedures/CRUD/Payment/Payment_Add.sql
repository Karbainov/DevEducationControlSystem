CREATE PROCEDURE [dbo].[Payment_Add]
@UserId int,
@GroupID int,
@Period int,
@Sum int,
@PayDate date
AS
INSERT into [dbo].[Payment]
(UserID, GroupID, Period, isPaid, Sum, PayDate)
VALUES
(@UserId, @GroupID, @Period, 1, @Sum, @PayDate)
