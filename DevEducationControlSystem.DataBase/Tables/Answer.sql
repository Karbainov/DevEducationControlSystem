CREATE TABLE [dbo].[Answer]
(
	ID INT CONSTRAINT PK_Answer PRIMARY KEY IDENTITY NOT NULL,
	UserID int NOT NULL,
	HomeWorkID int NOT NULL,
	Data datetime NOT NULL,
	Message nvarchar(1000),
	Links nvarchar(1000),
	Images nvarchar(1000),
	StatusID int NOT NULL
)
