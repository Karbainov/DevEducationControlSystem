CREATE procedure [dbo].[Payment_Update]
@UserID int,
@GroupID int,
@Period int,
@Sum int,
@isPaid bit,
@PayDate date
as
update [dbo].[Payment]
set UserId = @UserID, GroupId = @GroupID, Period = @Period, isPaid = @isPaid, Summ = @Sum, PayDate = @PayDate
where Id = @ID
