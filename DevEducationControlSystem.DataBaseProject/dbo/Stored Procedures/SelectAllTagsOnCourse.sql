CREATE PROCEDURE [dbo].[SelectAllTagsOnCourse]
as
select * 
	from Homework_Course as HC
	inner join Homework_Tag as HT on HC.HomeworkId=HT.HomeworkId
	inner join Course_Material as CM on HC.CourseId=CM.CourseId
	right outer join Material_Tag as MT on HT.TagId=MT.TagId
