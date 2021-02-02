CREATE PROCEDURE SelectStudentsStudyingAfterBase
AS
BEGIN

select
City.name as Cityname,
[Group].name as Groupname,
count( [User].id) as Usercount
from [Group]

right outer join city on ([group].CityId=city.id)
left join [User_Group] on [Group].Id = User_Group.groupid
left join [User] on User_Group.Userid = [User].id
left join [User_Role] on [User].id = User_Role.UserId

Where [User].Statusid = 5
and User_Role.RoleId = 2
Group By City.name, [Group].name
END