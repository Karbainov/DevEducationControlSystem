﻿CREATE TABLE [Homework_Tag] (
	ID int NOT NULL,
	HomeworkID int NOT NULL,
	TagID int NOT NULL,
  CONSTRAINT [PK_HOMEWORK_TAG] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)