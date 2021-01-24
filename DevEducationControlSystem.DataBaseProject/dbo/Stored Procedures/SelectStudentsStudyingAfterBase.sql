CREATE PROCEDURE [dbo].[SelectStudentsStudyingAfterBase]
as
select
count( [User].id) as Usercount
from [User]
left join [User_Group] on [User].Id = User_Group.Userid
left join [Group] on User_Group.Groupid = [Group].id
left join [User_Role] on [User].id = User_Role.UserId
Where [Group].Statusid = 4 and
([Group].Statusid =1 or [Group].Statusid =2 or [Group].Statusid =3 or [Group].Statusid = 4)
and User_Role.RoleId = 2	