CREATE PROCEDURE [dbo].[Material_Add]
@UserId int,
@ResourceId int,
@Name nvarchar(100),
@Message nvarchar(1000)
AS
INSERT into dbo.Material
(UserId, ResourceId, Name, Message, IsDeleted)
VALUES
(@UserId, @ResourceId, @Name, @Message, '0')
