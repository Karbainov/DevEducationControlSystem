﻿CREATE TABLE [dbo].[Answer_Status]
(
	ID INT CONSTRAINT PK_Answer_Status PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(100) NOT NULL UNIQUE,
)
