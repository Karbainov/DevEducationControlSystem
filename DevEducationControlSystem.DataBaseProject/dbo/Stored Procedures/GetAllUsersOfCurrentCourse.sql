CREATE PROCEDURE [dbo].[GetAllUsersOfCurrentCourse]
	@CourseId int
AS
	SELECT C.Id AS CourseId,C.Name AS Course, U.Id AS UserId, U.FirstName, U.LastName, US.Id As StatusId, US.Name AS UserStatus FROM [dbo].[Course] AS C
	join [dbo].[Group] AS G on G.CourseId = C.Id
	join [dbo].[User_Group] AS UG on UG.GroupId = G.Id
	Join [dbo].[User] AS U on U.Id = UG.UserId
	join [dbo].[UserStatus] AS US on US.Id = U.StatusId
	WHERE C.Id = @CourseId 
