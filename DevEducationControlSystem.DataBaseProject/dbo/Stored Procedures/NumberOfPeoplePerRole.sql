CREATE PROCEDURE [dbo].[NumberOfPeoplePerRole]
AS
select Role.Name, COUNT(User_Role.Id) NumberOfPeople From [Role]
full join [User_Role]  on [User_Role].RoleId = [Role].Id
Group By Role.Name