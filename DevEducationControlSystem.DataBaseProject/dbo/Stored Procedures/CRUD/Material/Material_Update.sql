CREATE procedure [dbo].[Material_Update]
@Id int,
@UserId int,
@Name nvarchar(100),
@Message nvarchar(1000),
@IsDeleted bit,
@ResourceId int
as
update dbo.Material
set UserID = @UserId, Name = @Name, Message = @Message, IsDeleted = @IsDeleted, ResourceId = @ResourceId
where ID = @Id
