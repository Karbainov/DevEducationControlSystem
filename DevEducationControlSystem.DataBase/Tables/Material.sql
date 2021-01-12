CREATE TABLE [Material] (
	ID int NOT NULL,
	UserID int NOT NULL,
	Name nvarchar(100) NOT NULL,
	Message nvarchar(1000),
	IsDeleted bit NOT NULL,	
	ResourceID int NOT NULL,
  CONSTRAINT [PK_MATERIAL] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)