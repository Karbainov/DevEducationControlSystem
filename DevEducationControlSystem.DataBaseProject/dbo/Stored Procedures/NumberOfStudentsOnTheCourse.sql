CREATE PROCEDURE [dbo].[NumberOfStudentsOnTheCourse]
	@CourseId int	
AS
  SELECT COUNT (MG.UserId)   
  FROM Course 
  inner join [Group] on Course.Id = [Group].CourseId  
  inner join [User_Group] as MG on [MG].GroupId = [Group].Id
  where Course.Id = @CourseId
