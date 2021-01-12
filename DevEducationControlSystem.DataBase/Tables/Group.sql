CREATE TABLE [Group] (
	ID int NOT NULL,
	StatusID int NOT NULL,
	CourseID int NOT NULL,
	CityID int NOT NULL,
	Name nvarchar(30),
	StartDate date,
  CONSTRAINT [PK_GROUP] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)