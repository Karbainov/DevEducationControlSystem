CREATE PROCEDURE [dbo].[Material_Add]
@UserId int,
@Name nvarchar(100),
@Message nvarchar(1000)
AS
INSERT into dbo.Material
(UserID, Name, Message, IsDeleted)
VALUES
(@UserId, @Name, @Message, 0)
