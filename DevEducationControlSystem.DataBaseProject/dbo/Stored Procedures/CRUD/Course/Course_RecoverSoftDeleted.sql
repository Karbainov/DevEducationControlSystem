CREATE PROCEDURE [dbo].[Course_RecoverSoftDeleted]
	@Id int

	AS
	UPDATE dbo.Course
	set IsDeleted = 0
	Where Id=@Id