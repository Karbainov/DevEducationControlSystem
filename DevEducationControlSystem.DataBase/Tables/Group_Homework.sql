CREATE TABLE Group_Homework
(
	ID INT CONSTRAINT PK_Group_Homework PRIMARY KEY IDENTITY NOT NULL,
	GroupID int NOT NULL,
	HomeworkID int NOT NULL,
	StartDate date,
	DeadLine date,
	CONSTRAINT [FK_Group_Homework_Group] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID]),
	CONSTRAINT [FK_Group_Homework_Homework] FOREIGN KEY ([HomeworkID]) REFERENCES [Homework]([ID])
)
