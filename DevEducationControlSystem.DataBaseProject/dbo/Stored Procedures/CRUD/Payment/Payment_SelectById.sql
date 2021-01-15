CREATE procedure [dbo].[Payment_SelectById]
@ID int
as
select * from [dbo].[Payment] where Id = @ID