CREATE TABLE [Group] 
(
	ID INT CONSTRAINT PK_Group PRIMARY KEY IDENTITY NOT NULL,
	StatusID int NOT NULL,
	CourseID int NOT NULL,
	CityID int NOT NULL,
	Name nvarchar(30),
	StartDate date,
	CONSTRAINT [FK_Group_GroupStatus] FOREIGN KEY ([StatusID]) REFERENCES [GroupStatus]([ID]),
	CONSTRAINT [FK_Group_Course] FOREIGN KEY ([CourseID]) REFERENCES [Course]([ID]),
	CONSTRAINT [FK_Group_City] FOREIGN KEY ([CityID]) REFERENCES [City]([ID])
)
