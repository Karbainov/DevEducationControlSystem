CREATE procedure [dbo].[Material_Update]
@Id int,
@UserId int,
@ResourceId int,
@Name nvarchar(100),
@Message nvarchar(1000),
@IsDeleted bit
as
update dbo.Material
set UserID = @UserId, ResourceId = @ResourceId, Name = @Name, Message = @Message, IsDeleted = @IsDeleted
where ID = @Id
