CREATE PROCEDURE [dbo].[SelectCityCourseHomeworkThemeStatus]
	
AS
BEGIN 
DECLARE @var table (HomeworkName nvarchar (100), ThemeName nvarchar (300) ,DoneHomework int, NotDoneHomework int, HomeworkDoneOnTime int,LateDoneHomework int )
INSERT @var EXEC SelectStudentsHomeworkStatus
SELECT City.[Name] as CityName, Course.[Name] as CourseName, GroupStatus.[Name] as GroupStatus, 
ThemeName,HomeworkName, DoneHomework,NotDoneHomework,HomeworkDoneOnTime,LateDoneHomework
FROM
(SELECT * FROM @var) as APO
JOIN
 Theme ON Theme.[Name] = APO.ThemeName 
JOIN
 Course_Theme  ON Theme.id= Course_Theme.ThemeId
 JOIN
 [Course] ON Course_Theme.CourseId=Course.Id
  JOIN
 [Group] ON [Course].Id=[Group].CourseId
 JOIN
 GroupStatus ON [Group].StatusId=GroupStatus.Id
JOIN
[City] ON [Group].CityId=City.Id

 EnD
