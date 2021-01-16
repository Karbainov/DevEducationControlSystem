CREATE procedure [dbo].[Payment_SelectById]
@Id int
as
select * from [dbo].[Payment] where Id = @Id