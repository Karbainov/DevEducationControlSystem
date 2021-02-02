CREATE PROCEDURE [dbo].[Course_Add]
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@DurationInWeeks int
AS
	INSERT INTO dbo.Course ([Name], [Description],DurationInWeeks)
	VALUES(	@Name, @Description,@DurationInWeeks)