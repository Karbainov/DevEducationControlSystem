CREATE PROCEDURE [dbo].[UpdateAllInfoOfUserById]
	@Id int,
	@FirstName nvarchar(30),
	@LastName nvarchar(30),
	@Login nvarchar(15), 
	@Password nvarchar(8),
	@BirthDate date,
	@email nvarchar(30),
	@ContractNumber nvarchar(15),
	@Phone nvarchar(12),
	@ProfileImage nvarchar(1000),
	@StatusId int
AS  
	UPDATE [dbo].[User]
	SET
	FirstName = @FirstName,
	LastName = @LastName,
	Login = @Login, 
	Password = @Password,
	BirthDate = @BirthDate,
	Email = @email,
	Phone = @Phone,
	ContractNumber = @ContractNumber,
	ProfileImage = @ProfileImage,
	StatusId = @StatusId
WHERE [dbo].[User].Id = @Id
