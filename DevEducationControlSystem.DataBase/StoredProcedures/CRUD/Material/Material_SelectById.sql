CREATE procedure [dbo].[Material_SelectById]
@Id int
as
select * from Material as M
where M.ID = @Id