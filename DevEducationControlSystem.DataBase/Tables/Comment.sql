CREATE TABLE [dbo].[Comment]
(
	ID INT CONSTRAINT PK_Comment PRIMARY KEY IDENTITY NOT NULL,
	UserID int NOT NULL,
	AnswerID int NOT NULL,
	Date datetime NOT NULL,
	Message nvarchar(1000),
)
