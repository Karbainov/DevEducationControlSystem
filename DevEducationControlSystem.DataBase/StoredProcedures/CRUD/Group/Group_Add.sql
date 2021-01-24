CREATE PROCEDURE Group_Add
	@ID int,
	@StatusID int,
	@CourseID int,
	@CityID int,
	@Name nvarchar(30),
	@StartDate date
AS
INSERT [Group] VALUES (@ID,
	@StatusID,
	@CourseID,
	@CityID,
	@Name,
	@StartDate)