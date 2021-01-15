CREATE procedure [dbo].[Material_Update]
@UserId int,
@Name nvarchar(100),
@Message nvarchar(1000),
@IsDeleted bit,
@Id int
as
update dbo.Material
set UserID = @UserId, Name = @Name, Message = @Message, IsDeleted = @IsDeleted
where ID = @Id
