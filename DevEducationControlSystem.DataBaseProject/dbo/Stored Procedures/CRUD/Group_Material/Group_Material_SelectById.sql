CREATE PROCEDURE Group_Material_SelectById 
	@Id int 
AS 
	SELECT * FROM [Group_Material] WHERE Id = @Id
