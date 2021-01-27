CREATE PROCEDURE [dbo].[SelectCourseByTagId]
@TagId int
as
select T.[Name] as TagName, C.[Name] as CourseName
from Tag as T
inner join Theme_Tag as TT on TT.TagId = T.Id
inner join Course_Theme as CT on CT.ThemeId = TT.ThemeId
inner join Course as C on C.Id = CT.CourseId
where T.Id = @TagId
