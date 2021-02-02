CREATE PROCEDURE [dbo].[GetAllHomeworksByTag]
	@Tag nvarchar(100)
AS
	SELECT 
	Tag.Name AS TagName,
	Homework.Id AS HomeworkId, 
	Homework.Name AS HomeworkName,
	Homework.Description AS HomeworkDescription

FROM Homework
LEFT JOIN 
	Homework_Tag ON Homework.Id=Homework_Tag.HomeworkId
LEFT JOIN 
	Tag ON Homework_Tag.TagId=Tag.Id

WHERE Tag.Name=@Tag AND Homework.isDeleted='False'
GO
