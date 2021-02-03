CREATE procedure [dbo].[Material_RecoverSoftDeleted]
@Id int
as
update dbo.Material
set IsDeleted = 0
where Id = @Id
