
Create PROC dbo.SelectStudentsByGroupId
@GroupID int
AS
select u.ID, CONCAT (u.FirstName,' ', u.LastName) as FullName, u.BirthDate,u.Login,u.Password,u.Phone,u.email  from [User] u 
join User_Group ug on u.id = ug.UserId
join [Group] g on ug.GroupID = g.ID 
join User_Role ur on u.Id = ur.UserId
join Role r on ur.RoleId = r.Id
where (GroupID = @GroupID) and (r.id = 2)

 exec SelectStudentsByGroupId 1
