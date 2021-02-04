CREATE PROCEDURE [dbo].[SelectUsersByGroupId]
	@GroupId int
AS
	select 
	U.Id UserId, U.FirstName, U.LastName, U.Login, U.Password, U.BirthDate, U.email, U.ContractNumber, U.Phone, U.ProfileImage,
	S.Id as StatusId, S.Name as [Status],
	R.Id, R.Name
  from [User] as U
  inner join [User_Role] as UR on [UR].UserId = U.Id
  inner join [Role] as R on UR.RoleId = R.Id
  inner join [User_Group] as UG on U.Id = [UG].UserId
  inner join [Group] as G on [UG].GroupId = G.Id
  inner join [UserStatus] as S on U.StatusId = S.Id
  where [G].Id = @GroupId