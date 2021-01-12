CREATE PROCEDURE User_Group_ReadById 
	@Id int 
AS 
	SELECT * FROM User_Group WHERE ID=@Id 
