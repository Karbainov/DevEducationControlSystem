CREATE PROCEDURE Group_Homework_Add 
	@GroupID int,
	@HomeworkID int,
	@StartDate date,
	@DeadLine date
AS
INSERT Group_Homework VALUES (@GroupID, @HomeworkID, @StartDate, @DeadLine)