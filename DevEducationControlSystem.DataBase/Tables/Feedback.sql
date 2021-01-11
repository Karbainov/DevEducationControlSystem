CREATE TABLE [Feedback] 
(
	ID INT CONSTRAINT PK_Feedback PRIMARY KEY IDENTITY  NOT NULL,
	UserID int NOT NULL,
	LessonID int NOT NULL,
	Message nvarchar(1000) NOT NULL,
	CONSTRAINT [FK_Feedback_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]),
	CONSTRAINT [FK_Feedback_Lesson] FOREIGN KEY ([LessonID]) REFERENCES [Lesson]([ID])
)