CREATE PROCEDURE Group_Add
	@StatusID int,
	@CourseID int,
	@CityID int,
	@Name nvarchar(100),
	@StartDate date
AS
INSERT [Group] VALUES (@StatusID,
	@CourseID,
	@CityID,
	@Name,
	@StartDate)