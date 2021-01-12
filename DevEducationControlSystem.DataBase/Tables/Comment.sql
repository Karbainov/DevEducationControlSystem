CREATE TABLE [Comment] (
	ID int NOT NULL,
	UserID int NOT NULL,
	AnswerID int NOT NULL,
	Date datetime NOT NULL,
	Message nvarchar(1000),	
	ResourceID int NOT NULL,
  CONSTRAINT [PK_COMMENT] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)