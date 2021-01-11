CREATE TABLE [dbo].[Homework_Tag]
(
	ID INT CONSTRAINT PK_Homework_Tag PRIMARY KEY IDENTITY NOT NULL,
	HomeworkID int NOT NULL,
	TagID int NOT NULL,
	CONSTRAINT [FK_Homework_Tag_Homework] FOREIGN KEY ([HomeworkID]) REFERENCES [Homework]([ID]),
    CONSTRAINT [FK_Homework_Tag_Course] FOREIGN KEY ([TagID]) REFERENCES [Tag]([ID]),
)
