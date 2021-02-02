CREATE PROCEDURE [dbo].[GetCourseDurationOfCurrentStudent]
	@UserId int
AS
	SELECT U.Id AS UserId, U.FirstName, U.LastName,US.Id As StatusId, US.Name AS UserStatus, C.Id AS CourseId, C.Name AS Course, G.StartDate, C.DurationInWeeks, DATEADD(week,C.DurationInWeeks,G.StartDate) As EndDate FROM [dbo].[User] AS U
	join [dbo].[User_Group] AS UG on UG.UserId = U.Id
	join [dbo].[Group] AS G on G.Id = UG.GroupId
	Join [dbo].[Course] AS C on C.Id = G.CourseId
	join [dbo].[UserStatus] AS US on US.Id = U.StatusId
	WHERE U.Id = @UserId 
