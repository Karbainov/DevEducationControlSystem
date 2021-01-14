CREATE TABLE [Group_Homework] (
	ID int NOT NULL,
	GroupID int NOT NULL,
	HomeworkID int NOT NULL,
	StartDate date,
	DeadLine date,
  CONSTRAINT [PK_GROUP_HOMEWORK] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)