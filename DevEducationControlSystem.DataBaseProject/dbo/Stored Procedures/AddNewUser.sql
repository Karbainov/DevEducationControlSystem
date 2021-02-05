CREATE PROCEDURE [dbo].[AddNewUser]
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
INSERT [dbo].[User] (FirstName, LastName, [Login], [Password], [BirthDate], email,ContractNumber,Phone,ProfileImage, StatusId)
VALUES(@FirstName, @LastName, @Login, @Password, @BirthDate, @email,@ContractNumber,@Phone,@ProfileImage, @StatusId)