CREATE TABLE [Course] (
	ID int NOT NULL,
	Name nvarchar(30) NOT NULL,
	Description nvarchar(3000),
	DurationInWeeks int,
	IsDeleted bit NOT NULL DEFAULT '0',
  CONSTRAINT [PK_COURSE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)