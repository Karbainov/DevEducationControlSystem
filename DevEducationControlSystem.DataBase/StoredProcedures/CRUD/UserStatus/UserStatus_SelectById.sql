CREATE PROCEDURE UserStatus_SelectById 
	@Id int 
AS 
	SELECT * FROM UserStatus WHERE ID = @Id