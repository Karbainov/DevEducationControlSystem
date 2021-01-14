CREATE TABLE [User] (
	ID int NOT NULL,
	StatusID int NOT NULL,
	FirstName nvarchar(30),
	LastName nvarchar(30),
	BirthDate date,
	Login nvarchar(15) NOT NULL UNIQUE,
	Password nvarchar(8) NOT NULL,
	email nvarchar(30),
	Phone nvarchar(12),
	ContractNumber nvarchar(15),
	ProfileImage nvarchar(1000),
  CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)