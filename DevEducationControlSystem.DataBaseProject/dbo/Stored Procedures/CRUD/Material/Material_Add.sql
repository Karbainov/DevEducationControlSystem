CREATE PROCEDURE [dbo].[Material_Add]
@UserId int,
@Name nvarchar(100),
@Message nvarchar(1000),
@ResourceId int
AS
INSERT into dbo.Material
(UserID, Name, Message, IsDeleted, ResourceId)
VALUES
(@UserId, @Name, @Message, '0', @ResourceId)
