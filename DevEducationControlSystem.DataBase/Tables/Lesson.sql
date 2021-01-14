CREATE TABLE [Lesson] (
	ID int NOT NULL,
	GroupID int NOT NULL,
	Name nvarchar(30) NOT NULL,
	LessonDate date NOT NULL,
	Comments nvarchar(1000),
  CONSTRAINT [PK_LESSON] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)