CREATE PROCEDURE [dbo].[SelectUserInfoByLogin]
	  @Login nvarchar(15)

AS
BEGIN
   SELECT [User].Id,[User].FirstName, [User].LastName, [User].BirthDate, [User].Email, [User].Phone, [User].ProfileImage, [Role].Name  
   FROM [User]
 

   JOIN User_Role ON [User_Role].UserId = [User].Id
   JOIN [Role] ON [User_Role].RoleId = [Role].Id
     WHERE [User].Login IN (@Login)
END
