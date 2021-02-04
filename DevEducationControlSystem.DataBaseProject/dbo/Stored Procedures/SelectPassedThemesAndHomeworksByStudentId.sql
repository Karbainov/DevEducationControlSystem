Create PROCEDURE [dbo].[SelectPassedThemesAndHomeworksByStudentId]
@StudentID int
AS
Select h.Id as HomeworkID,h.Name as HomeworkName, l.LessonDate,t.Id as ThemeID, t.Name as ThemeName,a.id as AnswerID, a.Date as AnswerDate, AnS.Name as AnswerStatus
From [User] u
join User_Group ug on ug.UserId = u.Id
join [Group] g on ug.GroupId = g.Id
join Lesson l on l.GroupId = g.Id
left join Lesson_Theme lt on lt.LessonId = l.Id
left join Theme t on t.Id = lt.ThemeId
left join Homework_Theme ht on ht.HomeworkId = t.Id
left join Homework h on ht.HomeworkId = h.Id
left join Answer a on h.id = a.HomeworkId and a.UserId = @StudentID
left join AnswerStatus AnS on AnS.Id = a.StatusId
join User_Role ur on u.Id = ur.UserId 
left join [Role] r on ur.RoleId = r.Id 

where (u.Id = @StudentID) and (r.Id=2)
and (LessonDate<GETDATE())
