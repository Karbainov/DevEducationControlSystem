CREATE PROCEDURE [dbo].[GetAllInformationAboutUserOnCourseById]
	@CourseId int
as	
  SELECT  [MG].UserId,
  [U].FirstName, [U].LastName,
  [MG].GroupId,
  [G].Name as GroupName,
  [Course].Id as CourseId, [Course].Name as CoursepName 
  FROM Course 
  inner join [Group] as G on Course.Id = [G].CourseId  
  inner join [User_Group] as MG on [MG].GroupId = [G].Id
  inner join [User] as U on [MG].UserId = [U].Id
  where Course.Id = @CourseId 