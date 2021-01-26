CREATE procedure [dbo].[GroupStatus_Update]
@Id int,
@Name nvarchar(100)
as
update dbo.GroupStatus
set Name = @Name
where Id = @Id
