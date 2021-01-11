CREATE TABLE [dbo].[Course]
(
	ID INT CONSTRAINT PK_Course PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(30) NOT NULL,
	Description nvarchar(3000),
	DurationInWeeks int,
	IsDeleted bit NOT NULL DEFAULT '0',
)
