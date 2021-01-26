CREATE PROCEDURE [dbo] . [User_Group_Delete] 
	@Id int 
AS 
	DELETE FROM [dbo] . [User_Group]  WHERE Id=@Id
