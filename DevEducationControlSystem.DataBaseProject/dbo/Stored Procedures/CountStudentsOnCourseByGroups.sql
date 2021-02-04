	CREATE PROCEDURE [dbo].[CountStudentsOnCourseByGroups]
	@CourseId int	
AS
  Select G.Id,G.[Name],COUNT(UG.UserId) AS CountOfStudentsInGroup
	from Course as C
	full join [Group] as G on C.ID=G.CourseId 
	full join [User_Group] as UG on G.Id=UG.GroupId
	where C.Id = @CourseId
	Group by G.Id,G.[Name],UG.GroupId