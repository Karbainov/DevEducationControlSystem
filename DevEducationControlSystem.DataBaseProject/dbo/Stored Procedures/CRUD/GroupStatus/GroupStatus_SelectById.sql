CREATE procedure [dbo].[GroupStatus_SelectById]
@Id int
as
select * from dbo.GroupStatus as G
where G.Id = @Id
