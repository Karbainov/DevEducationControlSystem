CREATE PROCEDURE Group_SelectById 
	@Id int 
AS 
	SELECT * FROM [Group] WHERE ID = @Id