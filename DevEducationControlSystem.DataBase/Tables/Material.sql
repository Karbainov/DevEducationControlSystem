CREATE TABLE [dbo].[Material]
(
	ID INT CONSTRAINT PK_Material PRIMARY KEY IDENTITY NOT NULL,
	UserID int NOT NULL,
	Name nvarchar(100) NOT NULL,
	Message nvarchar(1000),
	IsDeleted bit NOT NULL,
)
