CREATE TABLE [Homework] (
	ID int NOT NULL,
	Name nvarchar(100) NOT NULL,
	Description nvarchar(3000),
	IsDeleted bit NOT NULL,
	IsSolutionRequired bit NOT NULL,	
	ResourceID int NOT NULL,
  CONSTRAINT [PK_HOMEWORK] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)