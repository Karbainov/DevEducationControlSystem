CREATE procedure [dbo].[GroupStatus_SelectById]
@Id int
as
select * from GroupStatus as G
where G.ID = @Id
