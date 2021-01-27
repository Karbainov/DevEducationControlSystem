CREATE PROCEDURE [dbo].[SelectById]
	@Id int
AS
BEGIN
	SELECT * FROM Course WHERE Id=@Id AND IsDeleted<>1
END
