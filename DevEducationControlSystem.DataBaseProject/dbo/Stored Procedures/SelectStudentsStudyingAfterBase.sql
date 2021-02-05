CREATE PROCEDURE SelectStudentsStudyingAfterBase
AS
BEGIN

select
City.[Name] as CityName,
Course.[Name] as CourseName,
[Group].[Name] as GroupName,
count( [User].id) as UserStudyAfterBase
from [Group]

left join  City on ([Group].CityId=City.id)
left join Course on ([Group].Id=[Course].Id)
left join User_Group on [Group].Id = User_Group.groupid
left join [User] on User_Group.Userid = [User].id
left join [User_Role] on [User].id = User_Role.UserId

Where [Group].Statusid = 4 and
([Group].Statusid =1 or [Group].Statusid =2 or [Group].Statusid =3 or [Group].Statusid = 4)
and User_Role.RoleId = 2
Group By City.[Name], Course.[Name],[Group].[Name]

END