CREATE procedure [dbo].[Material_SelectSoftDeleted]
as
select * from dbo.Material
where dbo.Material.IsDeleted=1