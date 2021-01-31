CREATE PROCEDURE [dbo].[NumberOfStudentsOnTheCourse]
	@CourseId int	
AS
  SELECT  MG.UserId, MG.GroupId, 
  [Course].Id as CourseId, [Course].Name as GroupName  --COUNT (MG.UserId) As UsersCount  
  FROM [Course] 
  inner join [Group] on Course.Id = [Group].CourseId  
  inner join [User_Group] as MG on [MG].GroupId = [Group].Id
  where Course.Id = @CourseId