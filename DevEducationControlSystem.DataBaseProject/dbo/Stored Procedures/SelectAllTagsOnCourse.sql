CREATE PROCEDURE [dbo].[SelectAllTagsOnCourse]
@Id int
as
select distinct C.[Name] as Course, T.Id as TagId, T.[Name] as TagName
	from Course as C
	inner join Homework_Course as HC on C.Id = HC.CourseId
	inner join Homework_Tag as HT on HC.HomeworkId = HT.HomeworkId
	inner join Course_Material as CM on HC.CourseId = CM.CourseId
	inner join Material_Tag as MT on HT.TagId = MT.TagId
	inner join Tag as T on MT.TagId = T.Id
	where C.Id = @Id