﻿CREATE TABLE [Homework_Theme] (
	ID int NOT NULL,
	HomeworkD int NOT NULL,
	ThemeID int NOT NULL,
  CONSTRAINT [PK_HOMEWORK_THEME] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)