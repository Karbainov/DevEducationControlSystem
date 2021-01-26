CREATE PROCEDURE [dbo].[Course_Add]
	@Name nvarchar(100),
	@Description nvarchar(1000),
	@DurationInWeeks int,
	@IsDeleted bit	
AS
	INSERT INTO dbo.Course (Name, Description,DurationInWeeks, IsDeleted)
	VALUES(	@Name, @Description,@DurationInWeeks, @IsDeleted)