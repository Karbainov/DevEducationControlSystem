CREATE PROCEDURE Privileges_ReadById 
	@Id int 
AS 
	SELECT * FROM Privileges WERE ID = @Id