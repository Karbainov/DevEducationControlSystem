CREATE procedure [dbo].[GroupStatus_Update]
@Name nvarchar(100),
@Id int
as
update GroupStatus
set Name = @Name
where ID = @Id
