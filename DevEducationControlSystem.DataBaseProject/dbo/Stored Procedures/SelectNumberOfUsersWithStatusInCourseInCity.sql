CREATE PROCEDURE [dbo].[SelectNumberOfUsersWithStatusInCourseInCity]
	
AS
	select c.Id as CityId, 
 c.name as CityName, 
 cr.Id as CourseId, 
 cr.name as CourseName, 
 us.Id as StatusId, 
 us.Name as Status, 
 count(u.id) as UserCount 
 from [user] u 
 right outer join User_Group ug on u.id=ug.UserId 
 right outer join UserStatus us on u.StatusId=us.id
 right outer join [group] gr on ug.GroupId=gr.id 
 right outer join Course cr on gr.CourseId=cr.id
 join city c on gr.CityId=C.id
 group by c.Id, c.Name, cr.Id, cr.Name, us.Id, us.Name
