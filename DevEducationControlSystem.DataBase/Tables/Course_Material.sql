CREATE TABLE [dbo].[Course_Material]
(
	ID INT CONSTRAINT PK_Course_Material PRIMARY KEY IDENTITY NOT NULL,
	CourseID int NOT NULL,
	MaterialID int NOT NULL,
	CONSTRAINT [FK_Course_Material_Course] FOREIGN KEY ([CourseID]) REFERENCES [Course]([ID]),
    CONSTRAINT [FK_Course_Material_Material] FOREIGN KEY ([MaterialID]) REFERENCES [Material]([ID]),
)
