CREATE TABLE [Resource] (
	ID int NOT NULL,
	Links nvarchar(1000),
	Images nvarchar(1000),
  CONSTRAINT [PK_RESOURCE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)