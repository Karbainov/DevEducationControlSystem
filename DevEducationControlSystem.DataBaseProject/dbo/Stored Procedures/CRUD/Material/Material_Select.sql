CREATE procedure [dbo].[Material_Select]
as
select * from dbo.Material
Where IsDeleted<>0