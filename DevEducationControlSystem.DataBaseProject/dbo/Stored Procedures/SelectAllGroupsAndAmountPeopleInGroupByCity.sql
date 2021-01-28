CREATE PROCEDURE [dbo].[SelectAllGroupsAndAmountPeopleInGroupByCity]
as
select 

City.name as Cityname,
count(distinct [Group].id) as Groupcount,
SUM(CASE WHEN User_Role.RoleId = 2 THEN 1 ELSE 0 END) as Personcount

from [Group]
right outer join City on ([group].CityId=city.id) 
left join User_Group on [Group].id = User_Group.Groupid
left join [User] on User_Group.UserId = [User].Id
left join User_Role on [User].Id = User_Role.UserId
group by City.name
ORDER BY Cityname ASC
