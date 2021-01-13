CREATE procedure [dbo].[GroupStatus_Delete]
@Id int
as
delete dbo.GroupStatus
where ID = @Id