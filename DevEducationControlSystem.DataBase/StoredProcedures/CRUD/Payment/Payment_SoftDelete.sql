CREATE procedure [dbo].[Payment_SoftDelete]
@IsPaid bit,
@Id int
as
update [dbo].[Payment]
set IsPaid = @IsPaid
where ID = @Id
