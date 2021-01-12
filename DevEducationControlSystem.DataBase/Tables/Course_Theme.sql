CREATE TABLE [dbo].[Course_Theme]
(
	ID INT CONSTRAINT PK_Course_Theme PRIMARY KEY IDENTITY NOT NULL,
	CourseId int NOT NULL,
	ThemeID int NOT NULL,
	CONSTRAINT [FK_Course_Theme_Course] FOREIGN KEY ([CourseID]) REFERENCES [Course]([ID]),
    CONSTRAINT [FK_Course_Theme_Theme] FOREIGN KEY ([ThemeID]) REFERENCES [Theme]([ID]),
)
