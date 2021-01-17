CREATE procedure [dbo].[Payment_Update]
@UserId int,
@GroupID int,
@Period int,
@Sum int,
@isPaid bit,
@PayDate date
as
update [dbo].[Payment]
set UserID = @UserId, GroupID = @GroupID, Period = @Period, isPaid = @isPaid, Sum = @Sum, PayDate = @PayDate
where ID = @Id
