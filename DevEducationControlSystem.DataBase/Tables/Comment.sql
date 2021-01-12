CREATE TABLE [dbo].[Comment]
(
	ID INT CONSTRAINT PK_Comment PRIMARY KEY IDENTITY NOT NULL,
	UserID int NOT NULL,
	AnswerID int NOT NULL,
	Date datetime NOT NULL,
	Message nvarchar(1000),
	ResourcesID int NOT NULL,
	CONSTRAINT [FK_Comment_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]),
    CONSTRAINT [FK_Comment_Answer] FOREIGN KEY ([AnswerID]) REFERENCES [Answer]([ID]),
    CONSTRAINT [FK_Comment_Resources] FOREIGN KEY ([ResourcesID]) REFERENCES [Resources]([ID]),

)
