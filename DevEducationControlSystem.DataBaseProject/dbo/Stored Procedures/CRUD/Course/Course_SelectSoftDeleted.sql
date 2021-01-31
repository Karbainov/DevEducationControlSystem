CREATE PROCEDURE [dbo].[Course_SelectSoftDeleted]
	
AS
BEGIN
	SELECT * FROM Course WHERE IsDeleted=1
END