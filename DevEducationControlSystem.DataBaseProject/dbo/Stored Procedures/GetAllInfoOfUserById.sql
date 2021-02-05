CREATE PROCEDURE [dbo].[GetAllInfoOfUserById]
	@UserId int
AS
	SELECT U.Id, U.FirstName, U.LastName, U.Login, U.Password, U.BirthDate, U.email, U.ContractNumber, U.Phone, U.ProfileImage,
	S.Id as StatusId, S.Name as [Status],
	R.Id as RoleId, R.Name as [Role], 
	C.Id as CourseId, C.Name as Course, C.Description, G.StartDate, C.DurationInWeeks, DATEADD(week,C.DurationInWeeks,G.StartDate) As EndDate,
	G.Id as GroupId, G.Name as [Group]
  from [User] as U
 left join [User_Role] as UR on [UR].UserId = U.Id
  left join [Role] as R on UR.RoleId = R.Id
  left join [User_Group] as UG on U.Id = [UG].UserId
  left join [Group] as G on [UG].GroupId = G.Id
  left join [UserStatus] as S on U.StatusId = S.Id
  left join [Course] as C on  C.Id = G.CourseId
  Where U.Id = @UserId