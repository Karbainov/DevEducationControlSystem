CREATE TABLE [dbo].[Homework]
(
	ID INT CONSTRAINT PK_Homework PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(100) NOT NULL,
	Description nvarchar(3000),
	IsDeleted bit NOT NULL,
	IsSolutionRequired bit NOT NULL,
	
)
