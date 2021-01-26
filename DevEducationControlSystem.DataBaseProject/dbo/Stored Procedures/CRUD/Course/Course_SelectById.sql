CREATE PROCEDURE [dbo].[SelectById]
	@Id int
AS
BEGIN
	SELECT * FROM Course WHERE Id=@Id
END
