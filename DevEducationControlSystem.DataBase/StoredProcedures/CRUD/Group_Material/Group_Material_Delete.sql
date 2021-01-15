CREATE PROCEDURE Group_Material_Delete  
	@Id int  
AS  
	DELETE FROM [Group_Material] WHERE ID = @Id
