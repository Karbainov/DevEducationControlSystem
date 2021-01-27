CREATE PROCEDURE [dbo].[Course_Delete]  
	@Id int   
AS   
	UPDATE Course SET Course.IsDeleted=1 WHERE Id = @Id