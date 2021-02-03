CREATE PROCEDURE [dbo].[SelectStudentsHomeworkStatus]
as
SELECT

Aldo.HomeworkName, 
Aldo.ThemeName,
SUM(CASE WHEN Answer.StatusId = 5 or  Answer.StatusId = 6 THEN 1 ELSE 0 END) as DoneHomework,
SUM(CASE WHEN Answer.StatusId = 1 or Answer.StatusId = 2  THEN 1 ELSE 0 END) as NotDoneHomework,
SUM(CASE WHEN Answer.StatusId= 5 THEN 1 ELSE 0 END) as HomeworkDoneOnTime,
SUM(CASE WHEN Answer.StatusId = 6 THEN 1 ELSE 0 END) as LateDoneHomework


from (SELECT Homework.Id AS HomeworkId, Homework.[Name] as HomeworkName, [Description], 
Theme.[Name] as ThemeName, IsSolutionRequired
FROM Homework JOIN Homework_Theme ON Homework.Id=Homework_Theme.HomeworkId 
JOIN Theme on Theme.Id=Homework_Theme.ThemeId)  AS Aldo

left join Answer on (Aldo.HomeworkId = Answer.HomeworkId)

Where Aldo.IsSolutionRequired = 1
Group By Aldo.HomeworkName, Aldo.ThemeName 

