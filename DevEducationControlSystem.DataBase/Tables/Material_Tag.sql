﻿CREATE TABLE [Material_Tag] (
	ID int NOT NULL,
	MaterialID int NOT NULL,
	TagID int NOT NULL,
  CONSTRAINT [PK_MATERIAL_TAG] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)