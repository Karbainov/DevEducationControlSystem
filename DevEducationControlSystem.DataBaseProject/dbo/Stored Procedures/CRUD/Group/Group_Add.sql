CREATE PROCEDURE Group_Add
	@Id int,
	@StatusID int,
	@CourseID int,
	@CityID int,
	@Name nvarchar(100),
	@StartDate date
AS
INSERT [Group] VALUES (@Id,
	@StatusID,
	@CourseID,
	@CityID,
	@Name,
	@StartDate)