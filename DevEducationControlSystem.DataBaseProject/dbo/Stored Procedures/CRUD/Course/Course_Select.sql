CREATE PROCEDURE [dbo].[Course_Select]
	
AS
BEGIN
	SELECT * FROM Course WHERE IsDeleted<>1
END