CREATE TABLE [Attendance] 
(
	ID INT CONSTRAINT PK_Attendance PRIMARY KEY IDENTITY NOT NULL,
	UserID int NOT NULL,
	LessonID int NOT NULL,
	IsPresent bit NOT NULL,
	CONSTRAINT [FK_Attendance_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]),
	CONSTRAINT [FK_Attendance_Lesson] FOREIGN KEY ([LessonID]) REFERENCES [Lesson]([ID])
)