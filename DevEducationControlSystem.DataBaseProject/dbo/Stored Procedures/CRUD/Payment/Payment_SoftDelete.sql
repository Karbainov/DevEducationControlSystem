CREATE procedure [dbo].[Payment_SoftDelete]
@IsPaid bit,
@ID int
as
update [dbo].[Payment]
set IsPaid = @IsPaid
where Id = @ID
