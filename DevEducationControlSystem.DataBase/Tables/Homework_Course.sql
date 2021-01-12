CREATE TABLE [dbo].[Homework_Course]
(
	ID INT CONSTRAINT PK_Homework_Course PRIMARY KEY IDENTITY NOT NULL,
	HomeworkID int NOT NULL,
	CourseID int NOT NULL,
	CONSTRAINT [FK_Homework_Course_Homework] FOREIGN KEY ([HomeworkID]) REFERENCES [Homework]([ID]),
    CONSTRAINT [FK_Homework_Course_Course] FOREIGN KEY ([CourseID]) REFERENCES [Course]([ID]),
)
