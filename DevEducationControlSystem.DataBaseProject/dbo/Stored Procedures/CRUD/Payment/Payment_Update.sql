CREATE procedure [dbo].[Payment_Update]
@UserID int,
@GroupID int,
@Period int,
@isPaid bit,
@Sum int,
@PayDate date
as
update [dbo].[Payment]
set UserId = @UserID, GroupId = @GroupID, [Period] = @Period, isPaid = @isPaid, [Sum] = @Sum, PayDate = @PayDate
where Id = @ID
