CREATE PROCEDURE [dbo].[AllInfoUserOnTheCourse]
	@CourseId int 	
AS
SELECT [Course].Id as CourseId, [Course].Name as CourseName,
  [Group].Id as GroupId,[Group].Name as GroupName, 
  [UG].UserId, 
  [U].FirstName, [U].LastName,
  R.Name as Position, 
  [U].BirthDate, [U].Login, [U].Password, [U].email, [U].Phone, [U].ContractNumber,
  [US].Name as Status
  FROM Course 
  inner join [Group] on Course.Id = [Group].CourseId  
  inner join [User_Group] as UG on [UG].GroupId = [Group].Id
  inner join [User] as U on [U].Id = [UG].UserId
  inner join [UserStatus] as US on [US].Id = [U].StatusId 
  inner join [User_Role] as UR on [UR].UserId = [U].Id
  inner join [Role] as R on [R].Id = [UR].RoleId
  where Course.Id = CourseId
