CREATE TABLE [dbo].[Resources]
(
	ID INT CONSTRAINT PK_Resources PRIMARY KEY IDENTITY NOT NULL,
	Links nvarchar(1000),
	Images nvarchar(1000),
)
