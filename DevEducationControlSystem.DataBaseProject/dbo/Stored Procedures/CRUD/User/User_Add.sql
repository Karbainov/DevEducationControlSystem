CREATE PROCEDURE [dbo].[User_Add]
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
INSERT [dbo].[User] VALUES (
	@StatusID, 
	@FirstName, 
	@LastName, 
	@BirthDate,
	@Login, 
	@Password, 
	@email, 
	@Phone, 
	@ContractNumber,
	@ProfileImage
	
)