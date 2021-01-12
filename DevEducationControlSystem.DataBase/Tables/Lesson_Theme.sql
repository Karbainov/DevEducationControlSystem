CREATE TABLE [Lesson_Theme] (
	ID INT CONSTRAINT PK_Lesson_Theme PRIMARY KEY IDENTITY NOT NULL,
	LessonID int NOT NULL,
	ThemeID int NOT NULL,
	CONSTRAINT [FK_Lesson_Theme_Lesson] FOREIGN KEY ([LessonID]) REFERENCES [Lesson]([ID]),
	CONSTRAINT [FK_Lesson_Theme_Theme] FOREIGN KEY ([ThemeID]) REFERENCES [Theme]([ID])
)
