CREATE TABLE [Answer] (
	ID int NOT NULL,
	UserID int NOT NULL,
	HomeWorkID int NOT NULL,
	Data datetime NOT NULL,
	Message nvarchar(1000),
	Links nvarchar(1000),
	Images nvarchar(1000),
	StatusID int NOT NULL,
  CONSTRAINT [PK_ANSWER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)