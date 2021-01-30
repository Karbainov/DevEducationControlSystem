CREATE PROCEDURE [dbo].[UpdateUserProfile]
  
  @UserId int,
  @NewPassword nvarchar(8),
  @NewPhone nvarchar(12),
  @NewEmail nvarchar(30),
  @NewProfileImage nvarchar(1000)

AS
BEGIN
  UPDATE [User] SET

  [User].Password = @NewPassword, 
  [User].Phone = @NewPhone,
  [User].email = @NewEmail,
  [User].ProfileImage = @NewProfileImage

  WHERE Id = @UserId;

END
