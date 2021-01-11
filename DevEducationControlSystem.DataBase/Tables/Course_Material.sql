CREATE TABLE [dbo].[Course_Material]
(
	ID INT CONSTRAINT PK_Course_Material PRIMARY KEY IDENTITY NOT NULL,
	CourseID int NOT NULL,
	MaterialID int NOT NULL,
)
