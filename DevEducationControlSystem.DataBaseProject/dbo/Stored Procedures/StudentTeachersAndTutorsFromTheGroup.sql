CREATE PROCEDURE [dbo].[StudentTeachersAndTutorsFromTheGroup]
	@GroupId int
AS
	select UR.UserId, NAR.Name, [User].FirstName, [User].LastName, UG.GroupId, G.Name
  from [User]
  inner join [User_Role] as UR on [UR].UserId = [User].Id
  inner join [Role] as NAR on [UR].RoleId = [NAR].Id
  inner join [User_Group] as UG on [User].Id = [UG].UserId
  inner join [Group] as G on [UG].GroupId = G.Id
  where [G].Id = @GroupId