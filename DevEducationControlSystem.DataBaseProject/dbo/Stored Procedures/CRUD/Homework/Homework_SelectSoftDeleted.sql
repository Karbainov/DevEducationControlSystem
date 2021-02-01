CREATE PROCEDURE [dbo].[Homework_SelectSoftDeleted]
	AS
	SELECT	*	FROM dbo.Homework
	where dbo.Homework.IsDeleted=1