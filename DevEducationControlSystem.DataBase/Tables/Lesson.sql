CREATE TABLE [Lesson] 
(
	ID INT CONSTRAINT PK_Lesson PRIMARY KEY IDENTITY NOT NULL,
	GroupID int NOT NULL,
	Name nvarchar(30) NOT NULL,
	LessonDate date NOT NULL,
	Comments nvarchar(1000),
	CONSTRAINT [FK_Lesson_Group] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID])
)
