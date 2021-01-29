CREATE procedure [dbo].[Payment_Update]
@Id int,
@UserId int,
@GroupId int,
@Period int,
@isPaid bit,
@Sum int,
@PayDate date
as
update [dbo].[Payment]
set UserId = @UserId, GroupId = @GroupId, [Period] = @Period, isPaid = @isPaid, [Sum] = @Sum, PayDate = @PayDate
where Id = @Id
