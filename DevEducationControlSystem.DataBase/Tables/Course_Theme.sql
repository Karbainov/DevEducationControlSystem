﻿CREATE TABLE [dbo].[Course_Theme]
(
	ID INT CONSTRAINT PK_Course_Theme PRIMARY KEY IDENTITY NOT NULL,
	CourseId int NOT NULL,
	ThemeID int NOT NULL,
)
