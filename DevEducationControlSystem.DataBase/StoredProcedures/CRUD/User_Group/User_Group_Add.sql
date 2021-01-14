CREATE PROCEDURE [dbo] . [User_Group_Add]
	@UserId int, 
	@GroupId int
AS 

INSERT [dbo] . [User_Group] VALUES (@UserId, @GroupId)

