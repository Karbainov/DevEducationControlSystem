CREATE PROCEDURE [dbo].[SelectThemesByTag]
	@TagId int
as
select * 
	from Material_Tag as MT
	inner join Theme_Material as TM on TM.MaterialId=MT.MaterialId
	inner join Theme as T on T.Id=TM.ThemeId
	where MT.TagId = @TagId
