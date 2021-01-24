CREATE PROCEDURE [dbo] . [User_Group_SelectById] 
	@Id int 
AS 
	SELECT * FROM [dbo] . [User_Group] WHERE Id=@Id 
