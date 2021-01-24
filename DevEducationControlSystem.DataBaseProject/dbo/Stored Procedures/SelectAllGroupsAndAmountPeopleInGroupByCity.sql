CREATE PROCEDURE [dbo].[SelectAllGroupsAndAmountPeopleInGroupByCity]
as
select 

City.name as cityname,
count(distinct [Group].id) as groupcount,
SUM(CASE WHEN User_Role.RoleId = 2 THEN 1 ELSE 0 END) as personcount

from [Group]
right outer join city on ([group].CityId=city.id) 
left join User_Group on [Group].id = User_Group.Groupid
left join [User] on User_Group.UserId = [User].Id
left join User_Role on [User].Id = User_Role.UserId
group by city.name
ORDER BY cityname ASC
