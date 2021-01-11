CREATE TABLE [dbo].[Homework_Course]
(
	ID INT CONSTRAINT PK_Homework_Course PRIMARY KEY IDENTITY NOT NULL,
	Homework int NOT NULL,
	CourseID int NOT NULL,
)
