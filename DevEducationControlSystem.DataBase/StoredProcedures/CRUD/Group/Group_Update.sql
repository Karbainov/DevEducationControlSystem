﻿CREATE PROCEDURE Group_Update  
	@ID int,
	@StatusID int,
	@CourseID int,
	@CityID int,
	@Name nvarchar(30),
	@StartDate date
AS  
	UPDATE [Group] 
	SET
	StatusID = @StatusID,
	CourseID = @CourseID,
    CityID = @CityID,
	[Name] = @Name,
	StartDate = @StartDate
WHERE  
	ID=@Id