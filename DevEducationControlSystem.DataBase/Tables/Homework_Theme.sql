CREATE TABLE [dbo].[Homework_Theme]
(
	ID INT CONSTRAINT PK_Homework_Theme PRIMARY KEY IDENTITY NOT NULL,
	HomeworkID int NOT NULL,
	ThemeID int NOT NULL,
	CONSTRAINT [FK_Homework_Theme_Homework] FOREIGN KEY ([HomeworkID]) REFERENCES [Homework]([ID]),
    CONSTRAINT [FK_Homework_Theme_Theme] FOREIGN KEY ([ThemeID]) REFERENCES [Theme]([ID]),
)
