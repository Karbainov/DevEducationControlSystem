CREATE PROCEDURE [dbo].[SelectThemesByTagName]
@TagName nvarchar(255)
as
select T.Id as Id, T.[Name] as [Name]
	from Material_Tag as MT
	inner join Theme_Material as TM on TM.MaterialId=MT.MaterialId
	inner join Theme as T on T.Id=TM.ThemeId
	inner join Tag as TA on Ta.Id = MT.TagId
	where TA.Name = @TagName
