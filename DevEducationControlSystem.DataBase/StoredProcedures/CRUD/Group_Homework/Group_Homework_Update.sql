﻿CREATE PROCEDURE [dbo].[Group_Homework_Update]
	@Id int,
	@GroupID int,
	@HomeworkID int,
	@StartDate date,
	@DeadLine date
AS
	UPDATE Group_Homework
	SET
		GroupID = @GroupID,
		HomeworkID = @HomeworkID,
		StartDate = @StartDate,
		DeadLine = @DeadLine
WHERE
	Id=@Id