CREATE procedure [dbo].[Material_SoftDelete]
@Id int
as
update dbo.Material
set IsDeleted = 1
where Id = @Id
