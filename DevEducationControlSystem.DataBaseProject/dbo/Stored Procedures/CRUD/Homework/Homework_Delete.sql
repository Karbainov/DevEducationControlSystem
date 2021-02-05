CREATE PROCEDURE [dbo].[Homework_Delete]  
	@Id int 

	AS   
BEGIN
	declare @i int
	set @i = 1
	declare @tmp int
	set @tmp = (select count (C.Id) from Comment C join Answer A on C.AnswerId=A.Id where HomeworkId=@Id)

		WHILE (@i <= @tmp)
		BEGIN
			declare @tmpTable table (Id int)
			insert into @tmpTable select C.Id from Comment C join Answer A on C.AnswerId=A.Id where HomeworkId=@Id
			declare @commentID int
			set @commentID = (select top (1) Id from @tmpTable)

			DELETE FROM dbo.Comment where Comment.Id=@commentID

			delete top (1) from @tmpTable
			set @i = @i + 1
		END

	DELETE FROM dbo.Group_Homework where dbo.Group_Homework.HomeworkId=@Id
	DELETE FROM dbo.Homework_Course where dbo.Homework_Course.HomeworkId=@Id
	DELETE FROM dbo.Homework_Theme where dbo.Homework_theme.HomeworkId=@Id
	DELETE FROM dbo.Homework_Tag where dbo.Homework_Tag.HomeworkId=@Id
	DELETE FROM dbo.Answer where Answer.HomeworkId=@Id
	DELETE FROM dbo.Homework where Id=@Id
END