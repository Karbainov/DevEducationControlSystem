CREATE PROCEDURE [dbo].[SelectUserInfoByLogin]
	  @Login nvarchar(15)

AS
BEGIN
   SELECT [User].Id,[User].FirstName, [User].LastName, [User].BirthDate, [User].Email, [User].Phone, [User].ProfileImage,
   [Role].Name, [Group].Name, [Course].Name, [City].Name  
   FROM [User]
 

   JOIN User_Role ON [User_Role].UserId = [User].Id
   JOIN [Role] ON [User_Role].RoleId = [Role].Id
   JOIN [User_Group] ON [User_Group].UserId = [User].Id
   JOIN [Group] ON [Group].Id = [User_Group].GroupId
   JOIN [Course] ON [Course].Id = [Group].CourseId
   JOIN [City] ON [City].Id = [Group].CityId

     WHERE [User].Login IN (@Login)
END
