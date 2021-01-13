CREATE PROCEDURE User_Update
	@Id int,
	@StatusID int,
	@FirstName nvarchar(30),
	@LastName nvarchar(30),
	@BirthDate date,
	@Login nvarchar(15), 
	@Password nvarchar(8),
	@email nvarchar(30),
	@Phone nvarchar(12),
	@ContractNumber nvarchar(15),
	@ProfileImage nvarchar(1000)
AS  
	UPDATE [User]
	SET
	StatusID = @StatusID,
	FirstName = @FirstName,
	LastName = @LastName,
	BirthDate = @BirthDate,
	Login = @Login, 
	Password = @Password,
	email = @email,
	Phone = @Phone,
	ContractNumber = @ContractNumber,
	ProfileImage = @ProfileImage
WHERE  
	Id=@Id