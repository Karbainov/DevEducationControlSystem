CREATE PROCEDURE Role_Privileges_ReadById
	@Id int
AS
	SELECT * FROM Role_Privileges WERE ID = @Id